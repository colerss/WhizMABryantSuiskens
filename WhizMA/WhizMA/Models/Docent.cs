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

        public int DocentBeschrijvingID { get; set; }
        public ICollection<Cursus> Cursussen { get; set; }
    }
}
