using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhizMA.Areas.Identity.Data;
using WhizMA.Data;
using WhizMA.Models;

namespace WhizMA.ViewModels
{
    public class CursusDetailViewModel : DetailViewModel
    {
        public Cursus Cursus { get; set; }

        public string FormatId(CursusInhoud cursusInhoud, string append)
        {
            return append + cursusInhoud.CursusInhoudID;
        }

      

    }
}
