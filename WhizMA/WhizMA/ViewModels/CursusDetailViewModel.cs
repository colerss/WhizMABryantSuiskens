using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhizMA.Areas.Identity.Data;
using WhizMA.Data;
using WhizMA.Models;

namespace WhizMA.ViewModels
{
    public class CursusDetailViewModel
    {
        public Cursus Cursus { get; set; }

        public bool IsLogged { get; set; }
        public bool IsOwned { get; set; }
        public UserAccount CurrentUser { get; set; }
        public string FormatId(CursusInhoud cursusInhoud, string append)
        {
            return append + cursusInhoud.CursusInhoudID;
        }

      

    }
}
