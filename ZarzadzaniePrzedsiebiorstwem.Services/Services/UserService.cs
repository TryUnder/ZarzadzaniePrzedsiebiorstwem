using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZarzadzaniePrzedsiebiorstwem.Model.Authentication;
using ZarzadzaniePrzedsiebiorstwem.Services.Interfaces;
using ZarzadzaniePrzedsiebiorstwem.DAL.EF;
using Microsoft.AspNetCore.Http;

namespace ZarzadzaniePrzedsiebiorstwem.Services.Services {
    public class UserService : BaseService, IUserService {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ISession _session;

        public UserService(MyDbContext dbContext, IHttpContextAccessor httpContextAccessor) : base(dbContext) { 
            _httpContextAccessor = httpContextAccessor;
            _session = _httpContextAccessor.HttpContext.Session;
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

                _session.Set("UserId", Encoding.UTF8.GetBytes(existingUser.Id.ToString()));
                _session.Set("UserName", Encoding.UTF8.GetBytes(existingUser.Login));

            } catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
