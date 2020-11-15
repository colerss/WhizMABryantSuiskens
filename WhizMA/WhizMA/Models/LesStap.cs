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
        public string LesStapNaam { get; set; }

        public string LesStapText { get; set; }
        public string VideoAddress { get; set; }
        public TimeSpan StapTimeStamp { get; set; }

        public int LesID { get; set; }

        public int StapIconID { get; set; }

        public StapIcon StapIcon { get; set; }
        public Les Les { get; set; }
    }
}
