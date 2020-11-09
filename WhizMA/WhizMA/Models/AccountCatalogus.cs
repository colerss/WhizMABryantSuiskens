using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WhizMA.Areas.Identity.Data;

namespace WhizMA.Models
{
    public class AccountCatalogus
    {
        [Key]
        public int CatalogusItemID { get; set; }

        public int CursusID { get; set; }

        [ForeignKey("id")]
        public int AccountID { get; set; }


        [DataType(DataType.Date)]
        public DateTime VerloopTijd { get; set; }
        public int Voortgang { get; set; }

        //navprops

        public Cursus Cursus { get; set; }
        public Account Account { get; set; }
    }
}
