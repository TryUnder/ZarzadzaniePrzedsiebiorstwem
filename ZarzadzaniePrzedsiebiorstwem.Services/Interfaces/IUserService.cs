using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZarzadzaniePrzedsiebiorstwem.Model.Authentication;

namespace ZarzadzaniePrzedsiebiorstwem.Services.Interfaces {
    public interface IUserService {
        User RegisterAccount(User user);
        string? GetSessionIdFromCookie();
        void LoginUser(User user);
        User LogoutUser();
    }
}
