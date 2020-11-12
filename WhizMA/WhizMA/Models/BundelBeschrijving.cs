using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhizMA.Models
{
    public class BundelBeschrijving
    {
        public int BundelBeschrijvingID { get; set; }
        public string BundelInhoudsBeschrijving { get; set; }

        public Bundel Bundel { get; set; }
    }
}
