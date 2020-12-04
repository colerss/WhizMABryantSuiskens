using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhizMA.Models;

namespace WhizMA.ViewModels
{
    public class CatalogusBundelViewModel
    {
        public string BundelSearch { get; set; }
        public List<Bundel> Bundels { get; set; }

        public string BundelPrijs(decimal prijs)
        {
            return "€" + Math.Floor(prijs);
        }
    }
}
