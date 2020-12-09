using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhizMA.Areas.Identity.Data;

namespace WhizMA.ViewModels
{
    public abstract class DetailViewModel
    {
        //A battery of data to validate login info
        public bool IsLogged { get; set; }
        public bool IsOwned { get; set; }
        public UserAccount CurrentUser { get; set; }
    }
}
