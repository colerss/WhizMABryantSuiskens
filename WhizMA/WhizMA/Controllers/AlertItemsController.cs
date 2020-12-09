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
    public class AlertItemsController : Controller
    {
        private readonly WhizMAContext _context;

        public AlertItemsController(WhizMAContext context)
        {
            _context = context;
        }

        // GET: AlertItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.AlertItem.ToListAsync());
        }

        // GET: AlertItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alertItem = await _context.AlertItem
                .FirstOrDefaultAsync(m => m.AlertId == id);
            if (alertItem == null)
            {
                return NotFound();
            }

            return View(alertItem);
        }

        // GET: AlertItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AlertItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AlertId,AlertTitel,InfoText1,InfoText2,DateOfCreation,DateOfExpiry")] AlertItem alertItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alertItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(alertItem);
        }

        // GET: AlertItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alertItem = await _context.AlertItem.FindAsync(id);
            if (alertItem == null)
            {
                return NotFound();
            }
            return View(alertItem);
        }

        // POST: AlertItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AlertId,AlertTitel,InfoText1,InfoText2,DateOfCreation,DateOfExpiry")] AlertItem alertItem)
        {
            if (id != alertItem.AlertId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alertItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlertItemExists(alertItem.AlertId))
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
            return View(alertItem);
        }

        // GET: AlertItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alertItem = await _context.AlertItem
                .FirstOrDefaultAsync(m => m.AlertId == id);
            if (alertItem == null)
            {
                return NotFound();
            }

            return View(alertItem);
        }

        // POST: AlertItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alertItem = await _context.AlertItem.FindAsync(id);
            _context.AlertItem.Remove(alertItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlertItemExists(int id)
        {
            return _context.AlertItem.Any(e => e.AlertId == id);
        }
    }
}
