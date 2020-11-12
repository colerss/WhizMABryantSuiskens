using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WhizMA.Models
{
    public class Les
    {
        [Key]
        public int LesID { get; set; }
        [Required]
        public string Naam { get; set; }
        public TimeSpan Duur { get; set; }
        [Required]
        public string Beschrijving { get; set; }
        [Required]
        public string VideoAddress { get; set; }

        public ICollection<CursusInhoud> CursusInhouden{ get; set; }
        public ICollection<LesStap> LesStappen { get; set; }
    }
}
