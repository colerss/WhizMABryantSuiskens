using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhizMA.ViewModels;
using WhizMA.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WhizMA.ViewModels
{
    public class CursusCreateViewModel
    {
        public Cursus Cursus { get; set; }
        public CursusBeschrijving CursusBeschrijving { get; set; }
        public IEnumerable<SelectListItem> LessenLijst { get; set; }
        public IEnumerable<int> GeselecteerdeLessen { get; set; }
    }
}
