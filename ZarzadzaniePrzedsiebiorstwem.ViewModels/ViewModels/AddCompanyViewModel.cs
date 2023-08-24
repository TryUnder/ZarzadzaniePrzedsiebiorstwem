using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZarzadzaniePrzedsiebiorstwem.Model.Authentication;
using ZarzadzaniePrzedsiebiorstwem.Model.DataModels;

namespace ZarzadzaniePrzedsiebiorstwem.ViewModels.ViewModels
{
    public class AddCompanyViewModel
    {
        public User User { get; set; }
        public Przedsiebiorstwo Przedsiebiorstwo { get; set; }
    }
}
