using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WhizMA.Models
{
    public class CursusInhoud
    {
        [Key]
        public int CursusInhoudID { get; set; }
        public int CursusID { get; set; }
        public int LesID { get; set; }
        public int LesIntervalWeken { get; set; }
        public int Positie { get; set; }


        //Navprops

        public Cursus Cursus { get; set; }
        public Les Les { get; set; }
    }
}
