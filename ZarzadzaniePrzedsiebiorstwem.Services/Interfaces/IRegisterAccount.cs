using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZarzadzaniePrzedsiebiorstwem.Model.Authentication;

namespace ZarzadzaniePrzedsiebiorstwem.Services.Interfaces {
    public interface IRegisterAccount {
        User RegisterAccount(User user);
    }
}
