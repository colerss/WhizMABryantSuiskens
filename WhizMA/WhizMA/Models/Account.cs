using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhizMA.Models
{
    public class Account : IdentityUser
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }

    }
}
