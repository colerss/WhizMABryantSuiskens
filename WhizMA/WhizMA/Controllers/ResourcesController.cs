using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WhizMA.Controllers
{
    public class ResourcesController : Controller
    {
        public IActionResult FAQ()
        {
            return View();
        }
        public IActionResult Legal()
        {
            return View();
        }

    }
}
