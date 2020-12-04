using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhizMA.Models;

namespace WhizMA.ViewModels
{
    public class CatalogusCursussenViewModel
    {
        public string CursusSearch { get; set; }
        public int DocentSearch { get; set; }
        public List<Cursus> Cursussen { get; set; }

        public string CursusPrijs(decimal prijs)
        {
            return "€" + Math.Floor(prijs);
        }
    }
}
