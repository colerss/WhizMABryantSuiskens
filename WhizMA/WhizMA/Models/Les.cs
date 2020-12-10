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


        public List<CursusInhoud> CursusInhouden{ get; set; }
        public ICollection<LesStap> LesStappen { get; set; }
    }
}
