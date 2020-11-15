using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WhizMA.Models
{
    public class StapIcon
    {
        [Key]
        public int StapIconID { get; set; }

        public string StapIconClass { get; set; }
        public string StapIconPath { get; set; }

        public ICollection<LesStap> LesStappen { get; set; }
    }
}
