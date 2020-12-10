using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhizMA.Models;

namespace WhizMA.ViewModels
{
    public class BundelCreateViewModel
    {
        public Bundel Bundel { get; set; }
        public BundelBeschrijving BundelBeschrijving { get; set; }

        public IEnumerable<SelectListItem> CursusLijst { get; set; }
        public IEnumerable<int> GeselecteerdeCursussen { get; set; }
    }
}
