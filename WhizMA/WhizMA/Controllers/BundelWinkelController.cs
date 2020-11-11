using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WhizMA.Data;
using WhizMA.Models;

namespace WhizMA.Controllers
{
    public class BundelWinkelController : Controller
    {
        private readonly WhizMAContext _context;

        public BundelWinkelController(WhizMAContext context)
        {
            _context = context;
        }

        // GET: Bundels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bundels.ToListAsync());
        }

        // GET: Bundels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bundel = await _context.Bundels
                .FirstOrDefaultAsync(m => m.BundelID == id);
            if (bundel == null)
            {
                return NotFound();
            }

            return View(bundel);
        }

        // GET: Bundels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bundels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BundelID,Naam,Afbeelding,StandaardPrijs,HuidigePrijs")] Bundel bundel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bundel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bundel);
        }

        // GET: Bundels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bundel = await _context.Bundels.FindAsync(id);
            if (bundel == null)
            {
                return NotFound();
            }
            return View(bundel);
        }

        // POST: Bundels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BundelID,Naam,Afbeelding,StandaardPrijs,HuidigePrijs")] Bundel bundel)
        {
            if (id != bundel.BundelID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bundel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BundelExists(bundel.BundelID))
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
            return View(bundel);
        }

        // GET: Bundels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bundel = await _context.Bundels
                .FirstOrDefaultAsync(m => m.BundelID == id);
            if (bundel == null)
            {
                return NotFound();
            }

            return View(bundel);
        }

        // POST: Bundels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bundel = await _context.Bundels.FindAsync(id);
            _context.Bundels.Remove(bundel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BundelExists(int id)
        {
            return _context.Bundels.Any(e => e.BundelID == id);
        }
    }
}
