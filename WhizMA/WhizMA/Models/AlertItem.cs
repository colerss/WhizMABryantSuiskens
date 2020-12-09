using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WhizMA.Models
{
    public class AlertItem
    {

        [Key]
        public int AlertId { get; set; }
        public string AlertTitel { get; set; }
        public string InfoText1 { get; set; }
        public string InfoText2 { get; set; }
       
        [DataType(DataType.Date)]
        public DateTime DateOfCreation { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfExpiry { get; set; }

    }
}
