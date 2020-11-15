using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WhizMA.Models
{
    public class InfoNode
    {
        [Key]
        public int InfoID { get; set; }
        [Required]
        public string Titel { get; set; }
        public string Subtitel { get; set; }
        [Required]
        public string Beschrijving { get; set; }
        [Required]
        public string Afbeelding { get; set; }
        public int CursusBeschrijvingID { get; set; }

        //navprops

        public CursusBeschrijving CursusBeschrijving { get; set; }
    }
}
