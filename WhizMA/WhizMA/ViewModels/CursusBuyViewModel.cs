using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhizMA.Areas.Identity.Data;
using WhizMA.Data;
using WhizMA.Models;

namespace WhizMA.ViewModels
{
    public class CursusBuyViewModel
    {
        public int CursusID { get; set; }
        public int Beschikbaarheid { get; set; }
        public bool IsLogged { get; set; }
        public int CurrentUserID { get; set; }

      

    }
}
