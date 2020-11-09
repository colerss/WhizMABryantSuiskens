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

        public string Titel { get; set; }
        public string Subtitel { get; set; }
        public string beschrijving { get; set; }

        public string afbeelding { get; set; }
        public int CursusID { get; set; }

        //navprops

        public Cursus Cursus { get; set; }
    }
}
