using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WhizMA.Data;
using WhizMA.Models;
using WhizMA.ViewModels;

namespace WhizMA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WhizMAContext _context;
        public HomeController(ILogger<HomeController> logger, WhizMAContext context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            HomeViewModel viewModel = new HomeViewModel();
            viewModel.Cursussen = await _context.Cursussen
               .Include(c => c.Docent)
               .Include(c => c.CursusInhoud)
               .Include(c => c.CursusBeschrijving)
               .ToListAsync();

           List<AlertItem> allAlerts = await _context.AlertItem
                .Where(x => x.DateOfExpiry > DateTime.Today)
                .OrderByDescending(x => x.DateOfCreation)
                .ToListAsync();
            viewModel.MostRecentAlert = allAlerts.FirstOrDefault();
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
