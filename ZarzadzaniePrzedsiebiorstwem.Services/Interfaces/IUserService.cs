using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZarzadzaniePrzedsiebiorstwem.Model.Authentication;
using ZarzadzaniePrzedsiebiorstwem.Model.DataModels;

namespace ZarzadzaniePrzedsiebiorstwem.Services.Interfaces {
    public interface IUserService {
        User RegisterAccount(User user);
        void RegisterCompany(Przedsiebiorstwo company);
        string? GetSessionIdFromCookie();
        int GetUserIdByLogin(User user);
        User GetUserFromId(int id);
        void LoginUser(User user);
        User LogoutUser();
    }
}
