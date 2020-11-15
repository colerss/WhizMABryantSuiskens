using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WhizMA.Models
{
    public class Docent
    {
        [Key]
        public int DocentID { get; set; }
        [Required]
        public string DocentNaam { get; set; }
        [Required]
        public string DocentTitel { get; set; }
        public string DocentAfbeeldingURL { get; set; }
      
        public string DocentFB { get; set; }
        public string DocentIG { get; set; }
        public string DocentPin { get; set; }
        public string DocentBio { get; set; }

        public ICollection<Cursus> Cursussen { get; set; }
    }
}
