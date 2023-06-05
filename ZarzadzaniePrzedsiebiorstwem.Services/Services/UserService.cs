using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZarzadzaniePrzedsiebiorstwem.Model.Authentication;
using ZarzadzaniePrzedsiebiorstwem.Services.Interfaces;
using ZarzadzaniePrzedsiebiorstwem.DAL.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using System.Text.Json;
using Newtonsoft.Json;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;

namespace ZarzadzaniePrzedsiebiorstwem.Services.Services {
    public class UserService : BaseService, IUserService {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ISession _session;

        public UserService(MyDbContext dbContext, IHttpContextAccessor httpContextAccessor) : base(dbContext) { 
            _httpContextAccessor = httpContextAccessor;
            _session = _httpContextAccessor.HttpContext.Session;
        }

        public void UpdateSession(User user) {
            var userIdsBytes = _session.Get("UserIds");
            List<int>? userIds = userIdsBytes != null
                ? JsonConvert.DeserializeObject<List<int>>(Encoding.UTF8.GetString(userIdsBytes))
                : new List<int>();
            if (userIds.Any(id => user.Id == id)) {
                throw new Exception("Użytkownik jest już zalogowany");
            } else {
                userIds.Add(user.Id);
                _session.Set("UserIds", Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(userIds)));
                var cookieOptions = new CookieOptions {
                    Expires = DateTime.Now.AddMinutes(30)
                };

                _httpContextAccessor.HttpContext.Response.Cookies.Append("LoginCookie", user.Id.ToString(), cookieOptions);
            }
            Console.WriteLine(string.Join(", ", userIds));
        }

        public User RegisterAccount(User user) {
            try {
                if (_dbContext.User!.Any(u => u.Login == user.Login)) {
                    throw new Exception("Użytkownik o podanym loginie już istnieje");
                } else {
                    _dbContext.User!.Add(user);
                    _dbContext.SaveChanges();
                }
                return user;
            } catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }

        public void LoginUser(User user) {
            try {
                var existingUser = _dbContext.User.FirstOrDefault(u => u.Login == user.Login);

                if (existingUser == null) {
                    throw new Exception("Użytkownik o podanym loginie nie istnieje");
                }

                bool isPasswordValid = existingUser.Haslo == user.Haslo;

                if (!isPasswordValid) {
                    throw new Exception("Podane hasło jest nieprawidłowe");
                }

                UpdateSession(existingUser);

            } catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
