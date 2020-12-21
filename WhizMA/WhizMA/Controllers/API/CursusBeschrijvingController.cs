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
    public class CursusBeschrijvingController : ControllerBase
    {
        private readonly WhizMAContext _context;

        public CursusBeschrijvingController(WhizMAContext context)
        {
            _context = context;
        }

        // GET: api/CursusBeschrijving
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CursusBeschrijving>>> GetCursusBeschrijving()
        {
            return await _context.CursusBeschrijving.ToListAsync();
        }

        // GET: api/CursusBeschrijving/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CursusBeschrijving>> GetCursusBeschrijving(int id)
        {
            var cursusBeschrijving = await _context.CursusBeschrijving.FindAsync(id);

            if (cursusBeschrijving == null)
            {
                return NotFound();
            }

            return cursusBeschrijving;
        }

        // PUT: api/CursusBeschrijving/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCursusBeschrijving(int id, CursusBeschrijving cursusBeschrijving)
        {
            if (id != cursusBeschrijving.CursusBeschrijvingID)
            {
                return BadRequest();
            }

            _context.Entry(cursusBeschrijving).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CursusBeschrijvingExists(id))
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

        // POST: api/CursusBeschrijving
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost]
        public async Task<ActionResult<CursusBeschrijving>> PostCursusBeschrijving(CursusBeschrijving cursusBeschrijving)
        {
            _context.CursusBeschrijving.Add(cursusBeschrijving);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCursusBeschrijving", new { id = cursusBeschrijving.CursusBeschrijvingID }, cursusBeschrijving);
        }

        // DELETE: api/CursusBeschrijving/5
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete("{id}")]
        public async Task<ActionResult<CursusBeschrijving>> DeleteCursusBeschrijving(int id)
        {
            var cursusBeschrijving = await _context.CursusBeschrijving.FindAsync(id);
            if (cursusBeschrijving == null)
            {
                return NotFound();
            }

            _context.CursusBeschrijving.Remove(cursusBeschrijving);
            await _context.SaveChangesAsync();

            return cursusBeschrijving;
        }

        private bool CursusBeschrijvingExists(int id)
        {
            return _context.CursusBeschrijving.Any(e => e.CursusBeschrijvingID == id);
        }
    }
}
