using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WhizMA.Controllers
{
    public class TrailLessonController : Controller
    {
        public IActionResult Legal()
        {
            return View();
        }
        public IActionResult Strokes()
        {
            ViewData["vidUrl"] = "https://www.youtube.com/embed/9S-3Uk5-Zsg";
            return View();
        }
    }
}
