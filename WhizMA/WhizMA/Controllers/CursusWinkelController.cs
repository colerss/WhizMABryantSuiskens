﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WhizMA.Data;
using WhizMA.Models;
using WhizMA.ViewModels;
namespace WhizMA.Controllers
{
    public class CursusWinkelController : Controller
    {
        private readonly WhizMAContext _context;

        public CursusWinkelController(WhizMAContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Catalogus()
        {
            CatalogusCursussenViewModel viewModel = new CatalogusCursussenViewModel();
            viewModel.Cursussen = await _context.Cursussen
                .Include(c => c.Docent)
                .Include(c => c.CursusInhoud)
                .Include(c => c.CursusBeschrijving)
                .ToListAsync();

            ViewData["DocentID"] = new SelectList(_context.Docenten, "DocentID", "DocentNaam");
            return View(viewModel);
        }
        public async Task<IActionResult> Cursus(int? id)
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
        // GET: CursusWinkel
        public async Task<IActionResult> Index()
        {
            var whizMAContext = _context.Cursussen.Include(c => c.CursusBeschrijving).Include(c => c.Docent);
            return View(await whizMAContext.ToListAsync());
        }

        // GET: CursusWinkel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cursus = await _context.Cursussen
                .Include(c => c.CursusBeschrijving)
                .Include(c => c.Docent)
                .FirstOrDefaultAsync(m => m.CursusID == id);
            if (cursus == null)
            {
                return NotFound();
            }

            return View(cursus);
        }

        // GET: CursusWinkel/Create
        public IActionResult Create()
        {
            CursusCreateViewModel viewModel = new CursusCreateViewModel();
            viewModel.Cursus = new Cursus();
            viewModel.CursusBeschrijving = new CursusBeschrijving();
            ViewData["DocentID"] = new SelectList(_context.Docenten, "DocentID", "DocentNaam");
            return View();
        }

        // POST: CursusWinkel/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CursusCreateViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(viewModel.CursusBeschrijving);
                await _context.SaveChangesAsync();
                viewModel.Cursus.CursusBeschrijvingID = viewModel.CursusBeschrijving.CursusBeschrijvingID;
                _context.Add(viewModel.Cursus);
               
               
               
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DocentID"] = new SelectList(_context.Docenten, "DocentID", "DocentNaam", viewModel.Cursus.DocentID);
            return View(viewModel);
        }

        // GET: CursusWinkel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cursus = await _context.Cursussen.FindAsync(id);
            if (cursus == null)
            {
                return NotFound();
            }
            ViewData["CursusBeschrijvingID"] = new SelectList(_context.Set<CursusBeschrijving>(), "CursusBeschrijvingID", "CursusBeschrijvingID", cursus.CursusBeschrijvingID);
            ViewData["DocentID"] = new SelectList(_context.Docenten, "DocentID", "DocentNaam", cursus.DocentID);
            return View(cursus);
        }

        // POST: CursusWinkel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CursusID,Naam,StandaardPrijs,HuidigePrijs,CursusBeschrijvingID,Afbeelding,Gecertificieerd,BeschikbaarheidInMaanden,DocentID")] Cursus cursus)
        {
            if (id != cursus.CursusID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cursus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CursusExists(cursus.CursusID))
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
            ViewData["CursusBeschrijvingID"] = new SelectList(_context.Set<CursusBeschrijving>(), "CursusBeschrijvingID", "CursusBeschrijvingID", cursus.CursusBeschrijvingID);
            ViewData["DocentID"] = new SelectList(_context.Docenten, "DocentID", "DocentNaam", cursus.DocentID);
            return View(cursus);
        }

        // GET: CursusWinkel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cursus = await _context.Cursussen
                .Include(c => c.CursusBeschrijving)
                .Include(c => c.Docent)
                .FirstOrDefaultAsync(m => m.CursusID == id);
            if (cursus == null)
            {
                return NotFound();
            }

            return View(cursus);
        }

        // POST: CursusWinkel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cursus = await _context.Cursussen.FindAsync(id);
            _context.Cursussen.Remove(cursus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CursusExists(int id)
        {
            return _context.Cursussen.Any(e => e.CursusID == id);
        }
    }
}