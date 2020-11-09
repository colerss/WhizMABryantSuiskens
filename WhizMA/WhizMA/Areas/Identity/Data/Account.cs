using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WhizMA.Areas.Identity.Data
{
    public class Account : IdentityUser
    {
       
        [PersonalData]
        public string Naam { get; set; }

    }
}
