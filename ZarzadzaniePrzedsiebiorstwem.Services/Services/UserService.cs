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
using ZarzadzaniePrzedsiebiorstwem.ViewModels.ViewModels;
using ZarzadzaniePrzedsiebiorstwem.Model.DataModels;

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
			return _httpContextAccessor.HttpContext.Request.Cookies["LoginCookie"];
		}

		public User GetUserFromId(int id) {
			var userEntity = _dbContext.User!.FirstOrDefault(u => u.Id == id);
			return userEntity;
		}

		private void UpdateSession(User user) {
			var userList = GetUserListFromSession();
			var existingUser = userList.FirstOrDefault(u => u.Login == user.Login);
			
			if (existingUser != null) {
				var sessionId = GetSessionIdFromCookie();
				if (sessionId != null && existingUser.Id.ToString() == sessionId) {
					var userIndex = userList.FindIndex(u => u.Login == user.Login);
					userList[userIndex] = user;
					_session.SetString("UserIds", JsonConvert.SerializeObject(userList));
				} else {
					throw new Exception("Inny użytkownik jest już zalogowany na tym komputerze");
				}
			} else {
				var sessionId = Guid.NewGuid().ToString();
				userList.Add(user);
				_session.SetString("UserIds", JsonConvert.SerializeObject(userList));
				var cookieOptions = new CookieOptions {
					Expires = DateTime.Now.AddMinutes(30)
				};

				_httpContextAccessor.HttpContext.Response.Cookies.Append("LoginCookie", user.Id.ToString(), cookieOptions);
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

		public void RegisterCompany(Przedsiebiorstwo company) {
			try {
				if (_dbContext.Przedsiebiorstwo!.Any(p => p.UserId == company.UserId)) {
					throw new Exception("Użytkownik już ma przypisane przedsiębiorstwo");
				} else {
					_dbContext.Przedsiebiorstwo!.Add(company);
					_dbContext.SaveChanges();
				}
			} catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
		}

		public int GetUserIdByLogin(User user) {
			var users = _dbContext.User!.ToList();
			int userId = users.Where(u => u.Login == user.Login)
							  .Select(u => u.Id)
							  .FirstOrDefault();
			return userId;
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
				
				user.Id = GetUserIdByLogin(user);

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

		public User LogoutUser() {
			try {
				var userList = GetUserListFromSession();
				var sessionId = GetSessionIdFromCookie();
		
				if (!string.IsNullOrEmpty(sessionId)) {
					var loggedUser = userList.FirstOrDefault(u => u.Id.ToString() == sessionId);
					if (loggedUser != null) {
						userList.Remove(loggedUser);
						_session.SetString("UserIds", JsonConvert.SerializeObject(userList));
					}
					_httpContextAccessor.HttpContext.Response.Cookies.Delete("LoginCookie");
					return loggedUser;
				}
				_httpContextAccessor.HttpContext.Response.Cookies.Delete("LoginCookie");
			} catch (Exception e) {
				Console.WriteLine(e);
				throw;
			}
			return null;
		}
	}
}