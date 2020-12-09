using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WhizMA.Data;
using WhizMA.Models;
using Microsoft.AspNetCore.Identity;
using WhizMA.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace WhizMA.Controllers
{
    [Authorize(Policy = "writepolicy")]
    public class AccountCatalogusController : Controller
    {
        private readonly WhizMAContext _context;

        public AccountCatalogusController(WhizMAContext context)
        {
            _context = context;
        }

        // GET: AccountCatalogus
     
        public async Task<IActionResult> Index()
        {
            var whizMAContext = _context.AccountCatalogus.Include(a => a.Account).Include(a => a.Cursus);
            return View(await whizMAContext.ToListAsync());
        }
        [Authorize(Policy = "readpolicy")]
        public async Task<IActionResult> UserCatalogue()
        {
           AccountCatalogusViewModel viewModel = new AccountCatalogusViewModel();
            viewModel.Cursussen = await _context.AccountCatalogus
                .Where(c => c.Account.UserName == User.Identity.Name)
                .Include(c => c.Cursus)
                 .Include(c => c.Cursus.Docent)
                .Include(c => c.Cursus.CursusInhoud)
                .Include(c => c.Cursus.CursusBeschrijving)
                .ToListAsync();
            ViewData["Docent"] = new SelectList(_context.Docenten, "DocentID", "DocentNaam");
            return View(viewModel);
        }
        [Authorize(Policy = "readpolicy")]
        public async Task<IActionResult> Les(int? id)
        {
            CursusDetailViewModel viewModel = new CursusDetailViewModel();
            if (id == null)
            {
                return NotFound();
            }

            var cursus = await _context.Cursussen
                .Include(c => c.Docent)
                .Include(c => c.CursusInhoud)
                .ThenInclude(c => c.Les)
                .ThenInclude(c => c.LesStappen)
                .ThenInclude(c => c.StapIcon)
                .Include(c => c.CursusBeschrijving)
                .ThenInclude(c => c.InfoNodes)
                .FirstOrDefaultAsync(m => m.CursusID == id);
            if (cursus == null)
            {
                return NotFound();
            }
            viewModel.Cursus = cursus;
            return View(viewModel);
        }
        // GET: AccountCatalogus/Details/5
      
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountCatalogus = await _context.AccountCatalogus
                .Include(a => a.Account)
                .Include(a => a.Cursus)
                .FirstOrDefaultAsync(m => m.CatalogusItemID == id);
            if (accountCatalogus == null)
            {
                return NotFound();
            }

            return View(accountCatalogus);
        }

        // GET: AccountCatalogus/Create
  
        public IActionResult Create()
        {
            ViewData["AccountID"] = new SelectList(_context.Account, "Id", "Id");
            ViewData["CursusID"] = new SelectList(_context.Cursussen, "CursusID", "Afbeelding");
            return View();
        }

        // POST: AccountCatalogus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CatalogusItemID,CursusID,AccountID,VerloopTijd,Voortgang")] AccountCatalogus accountCatalogus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accountCatalogus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountID"] = new SelectList(_context.Account, "Id", "Id", accountCatalogus.AccountID);
            ViewData["CursusID"] = new SelectList(_context.Cursussen, "CursusID", "Afbeelding", accountCatalogus.CursusID);
            return View(accountCatalogus);
        }
       
        // GET: AccountCatalogus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountCatalogus = await _context.AccountCatalogus.FindAsync(id);
            if (accountCatalogus == null)
            {
                return NotFound();
            }
            ViewData["AccountID"] = new SelectList(_context.Account, "Id", "Id", accountCatalogus.AccountID);
            ViewData["CursusID"] = new SelectList(_context.Cursussen, "CursusID", "Afbeelding", accountCatalogus.CursusID);
            return View(accountCatalogus);
        }

        // POST: AccountCatalogus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CatalogusItemID,CursusID,AccountID,VerloopTijd,Voortgang")] AccountCatalogus accountCatalogus)
        {
            if (id != accountCatalogus.CatalogusItemID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accountCatalogus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountCatalogusExists(accountCatalogus.CatalogusItemID))
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
            ViewData["AccountID"] = new SelectList(_context.Account, "Id", "Id", accountCatalogus.AccountID);
            ViewData["CursusID"] = new SelectList(_context.Cursussen, "CursusID", "Afbeelding", accountCatalogus.CursusID);
            return View(accountCatalogus);
        }
        // GET: AccountCatalogus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountCatalogus = await _context.AccountCatalogus
                .Include(a => a.Account)
                .Include(a => a.Cursus)
                .FirstOrDefaultAsync(m => m.CatalogusItemID == id);
            if (accountCatalogus == null)
            {
                return NotFound();
            }

            return View(accountCatalogus);
        }

        // POST: AccountCatalogus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accountCatalogus = await _context.AccountCatalogus.FindAsync(id);
            _context.AccountCatalogus.Remove(accountCatalogus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountCatalogusExists(int id)
        {
            return _context.AccountCatalogus.Any(e => e.CatalogusItemID == id);
        }
    }
}
