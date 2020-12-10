using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WhizMA.Data;
using WhizMA.Models;

namespace WhizMA.Controllers
{
    [Authorize(Policy = "writepolicy")]
    public class LesController : Controller
    {
        private readonly WhizMAContext _context;

        public LesController(WhizMAContext context)
        {
            _context = context;
        }

        // GET: Les
        public async Task<IActionResult> Index()
        {
            return View(await _context.Lessen.ToListAsync());
        }

        // GET: Les/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var les = await _context.Lessen
                .FirstOrDefaultAsync(m => m.LesID == id);
            if (les == null)
            {
                return NotFound();
            }

            return View(les);
        }

        // GET: Les/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Les/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LesID,Naam")] Les les)
        {
            if (ModelState.IsValid)
            {
                _context.Add(les);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(les);
        }

        // GET: Les/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var les = await _context.Lessen.FindAsync(id);
            if (les == null)
            {
                return NotFound();
            }
            return View(les);
        }

        // POST: Les/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LesID,Naam")] Les les)
        {
            if (id != les.LesID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(les);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LesExists(les.LesID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(les);
        }

        // GET: Les/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var les = await _context.Lessen
                .FirstOrDefaultAsync(m => m.LesID == id);
            if (les == null)
            {
                return NotFound();
            }

            return View(les);
        }

        // POST: Les/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var les = await _context.Lessen.FindAsync(id);
            _context.Lessen.Remove(les);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LesExists(int id)
        {
            return _context.Lessen.Any(e => e.LesID == id);
        }
    }
}
