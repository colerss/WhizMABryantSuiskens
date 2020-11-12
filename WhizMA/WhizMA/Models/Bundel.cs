using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WhizMA.Models
{
    public class Bundel
    {
        [Key]
        public int BundelID { get; set; }
        [Required]
        public string Naam { get; set; }
        [Required]
        public string Afbeelding { get; set; }
        public decimal StandaardPrijs { get; set; }
        public decimal HuidigePrijs { get; set; }
        
        public int BundelBeschrijvingID { get; set; }
        public BundelBeschrijving BundelBeschrijving { get; set; }

        public ICollection<BundelInhoud> BundelInhoud { get; set; }
    }
}
