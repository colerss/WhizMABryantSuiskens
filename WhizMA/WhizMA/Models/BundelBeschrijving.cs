using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WhizMA.Models
{
    public class BundelBeschrijving
    {
        [Key]
        public int BundelBeschrijvingID { get; set; }
        public string BundelInhoudsBeschrijving { get; set; }

        //Deze relatie is op één of meer gezet puur omdat het anders problemen met React geeft
        public List<Bundel> Bundels { get; set; }
    }
}
