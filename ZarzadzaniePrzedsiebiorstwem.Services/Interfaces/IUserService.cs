using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZarzadzaniePrzedsiebiorstwem.Model.Authentication;

namespace ZarzadzaniePrzedsiebiorstwem.Services.Interfaces {
    public interface IUserService {
        User RegisterAccount(User user);
        void LoginUser(User user);
    }
}
