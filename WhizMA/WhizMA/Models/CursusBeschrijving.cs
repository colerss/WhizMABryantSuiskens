using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WhizMA.Models
{
    public class CursusBeschrijving
    {
        [Key]
        public int CursusBeschrijvingID { get; set; }
        public string InhoudBeschrijving { get; set; }
        public string VoorWieBeschrijving { get; set; }

        public string CertificaatBeschrijving { get; set; }

        public List<Cursus> Cursussen { get; set; }
        public ICollection<InfoNode> InfoNodes { get; set; }
    }
}
