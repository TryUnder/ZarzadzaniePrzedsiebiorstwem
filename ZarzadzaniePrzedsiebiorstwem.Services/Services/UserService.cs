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
        private ISession _session => _httpContextAccessor.HttpContext.Session;

        public UserService(MyDbContext dbContext, IHttpContextAccessor httpContextAccessor) : base(dbContext) { 
            _httpContextAccessor = httpContextAccessor;
        }

        private List<User>? GetUserListFromSession() {
            var userIdsBytes = _session.Get("UserIds");

            if (userIdsBytes == null) {
                return new List<User>();
            }

            var userIdsString = Encoding.UTF8.GetString(userIdsBytes);

            return string.IsNullOrEmpty(userIdsString) ? new List<User>()
                : JsonConvert.DeserializeObject<List<User>>(userIdsString);
        }

        public string? GetSessionIdFromCookie() {
            return _httpContextAccessor.HttpContext.Request.Cookies["SessionId"];
        }

        private void UpdateSession(User user) {
            
            var userList = GetUserListFromSession();
            if (userList.Any(u => u.Id == user.Id)) {
                throw new Exception("Użytkownik jest już zalogowany");
            } else {
                var sessionId = Guid.NewGuid().ToString();
                userList.Add(user);
                _session.SetString("UserIds", JsonConvert.SerializeObject(userList));
                var cookieOptions = new CookieOptions {
                    Expires = DateTime.Now.AddMinutes(30)
                };

                _httpContextAccessor.HttpContext.Response.Cookies.Append("SessionId", sessionId, cookieOptions);
            }
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

                var sessionId = GetSessionIdFromCookie();

                if (!string.IsNullOrEmpty(sessionId)) {
                    throw new Exception("Inny użytkownik jest już zalogowany na tym komputerze");
                }

                UpdateSession(existingUser);

            } catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }

        public void LogoutUser() {
            try {
                var sessionId = GetSessionIdFromCookie();
                if (!string.IsNullOrEmpty(sessionId)) {
                    _httpContextAccessor.HttpContext.Response.Cookies.Delete("SessionId");
                }
            } catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
