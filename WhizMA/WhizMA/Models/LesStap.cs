using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WhizMA.Models
{
    public class LesStap
    {
        [Key]
        public int LesStapID { get; set; }
        public int LesStapNaam { get; set; }

        public string LesStapText { get; set; }
        public TimeSpan StapTimeStamp { get; set; }
        public string StapIcon { get; set; }

        public int LesID { get; set; }

        public Les Les { get; set; }
    }
}
