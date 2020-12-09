using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhizMA.Models;

namespace WhizMA.ViewModels
{
    public class HomeViewModel
    {

        public AlertItem MostRecentAlert { get; set; }
        public List<Cursus> Cursussen {get;set;}
    }
}
