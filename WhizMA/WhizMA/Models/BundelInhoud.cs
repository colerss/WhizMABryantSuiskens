using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WhizMA.Models
{
    public class BundelInhoud
    {
        [Key]
        public int BundelInhoudID { get; set; }
        public int BundelID { get; set; }
        public int CursusID { get; set; }

        //navprops

        public Bundel Bundel { get; set; }
        public Cursus Cursus { get; set; }
    }
}
