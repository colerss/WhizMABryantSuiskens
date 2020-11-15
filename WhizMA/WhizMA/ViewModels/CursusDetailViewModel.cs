using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhizMA.Models;

namespace WhizMA.ViewModels
{
    public class CursusDetailViewModel
    {
        public Cursus Cursus { get; set; }


        public string FormatId(CursusInhoud cursusInhoud, string append)
        {
            return append + cursusInhoud.CursusInhoudID;
        }
    }
}
