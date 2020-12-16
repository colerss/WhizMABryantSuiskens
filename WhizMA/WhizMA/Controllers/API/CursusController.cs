using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WhizMA.Data;
using WhizMA.Models;

namespace WhizMA.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursusController : ControllerBase
    {
        private readonly WhizMAContext _context;

        public CursusController(WhizMAContext context)
        {
            _context = context;
        }

        // GET: api/Cursus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cursus>>> GetCursussen()
        {
            return await _context.Cursussen.Include(x => x.CursusInhoud).Include(r => r.CursusBeschrijving).ToListAsync();
        }
        // GET: api/Cursus/Afbeeldingen
        [HttpGet("Afbeeldingen")]
        public async Task<ActionResult<IEnumerable<string>>> GetAfbeeldingen()
        {
            return await _context.Cursussen.Select(x => x.Afbeelding).ToListAsync();
        }

        // GET: api/Cursus/5
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("{id}")]
        public async Task<ActionResult<Cursus>> GetCursus(int id)
        {
            var cursus = await _context.Cursussen.FindAsync(id);

            if (cursus == null)
            {
                return NotFound();
            }

            return cursus;
        }

        // PUT: api/Cursus/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCursus(int id, Cursus cursus)
        {
            if (id != cursus.CursusID)
            {
                return BadRequest();
            }

            _context.Entry(cursus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CursusExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Cursus
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost]
        public async Task<ActionResult<Cursus>> PostCursus(Cursus cursus)
        {
            _context.Cursussen.Add(cursus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCursus", new { id = cursus.CursusID }, cursus);
        }

        // DELETE: api/Cursus/5
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cursus>> DeleteCursus(int id)
        {
            var cursus = await _context.Cursussen.FindAsync(id);
            if (cursus == null)
            {
                return NotFound();
            }

            _context.Cursussen.Remove(cursus);
            await _context.SaveChangesAsync();

            return cursus;
        }

        private bool CursusExists(int id)
        {
            return _context.Cursussen.Any(e => e.CursusID == id);
        }
    }
}
