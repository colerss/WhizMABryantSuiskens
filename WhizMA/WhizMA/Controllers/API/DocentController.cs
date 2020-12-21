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
    public class DocentController : ControllerBase
    {
        private readonly WhizMAContext _context;

        public DocentController(WhizMAContext context)
        {
            _context = context;
        }

        // GET: api/Docent
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Docent>>> GetDocenten()
        {
            return await _context.Docenten.ToListAsync();
        }

        // GET: api/Docents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Docent>> GetDocent(int id)
        {
            var docent = await _context.Docenten.FindAsync(id);

            if (docent == null)
            {
                return NotFound();
            }

            return docent;
        }

        // PUT: api/Docents/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDocent(int id, Docent docent)
        {
            if (id != docent.DocentID)
            {
                return BadRequest();
            }

            _context.Entry(docent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocentExists(id))
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

        // POST: api/Docents
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost]
        public async Task<ActionResult<Docent>> PostDocent(Docent docent)
        {
            _context.Docenten.Add(docent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDocent", new { id = docent.DocentID }, docent);
        }

        // DELETE: api/Docents/5
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Docent>> DeleteDocent(int id)
        {
            var docent = await _context.Docenten.FindAsync(id);
            if (docent == null)
            {
                return NotFound();
            }

            _context.Docenten.Remove(docent);
            await _context.SaveChangesAsync();

            return docent;
        }

        private bool DocentExists(int id)
        {
            return _context.Docenten.Any(e => e.DocentID == id);
        }
    }
}
