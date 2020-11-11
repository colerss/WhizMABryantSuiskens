using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WhizMA.Models
{
    public class Cursus
    {
        [Key]
        public int CursusID { get; set; }
        [Required]
        public string Naam { get; set; }
        public decimal StandaardPrijs { get; set; }
        public decimal HuidigePrijs { get; set; }
        [Required]
        public string Beschrijving { get; set; }
        [Required]
        public string Afbeelding { get; set; }
        public bool Gecertificieerd { get; set; }
        public int BeschikbaarheidInMaanden { get; set; }
        public int DocentID { get; set; }



        public Docent Docent { get; set; }
        public ICollection<CursusInhoud> CursusInhoud { get; set; }
        public ICollection<InfoNode> InfoNodes { get; set; }
        public ICollection<BundelInhoud> BundelInhoud { get; set; }
        public ICollection<AccountCatalogus> AccountCatalogus { get; set; }
    }
}
