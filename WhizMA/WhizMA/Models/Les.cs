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
        public string Naam { get; set; }
        public TimeSpan Duur { get; set; }
        public string Beschrijving { get; set; }

        public string VideoAddress { get; set; }

        public ICollection<CursusInhoud> CursusInhoud{ get; set; }
    }
}
