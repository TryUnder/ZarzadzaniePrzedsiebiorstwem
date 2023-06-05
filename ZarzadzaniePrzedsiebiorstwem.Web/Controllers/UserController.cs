using Microsoft.AspNetCore.Mvc;
using ZarzadzaniePrzedsiebiorstwem.Model.Authentication;
using ZarzadzaniePrzedsiebiorstwem.Services.Interfaces;

namespace ZarzadzaniePrzedsiebiorstwem.Web.Controllers {
    public class UserController : Controller {

        private readonly IUserService _registerAccount;

        public UserController(IUserService registerAccount) {
            _registerAccount = registerAccount;
        }

        public IActionResult WidokRejestracji() {
            return View("WidokRejestracji");
        }

        [HttpPost] public IActionResult RegisterAccount(User user) {
            var autor = _registerAccount.RegisterAccount(user);
            return View("ZarejestrowanyUzytkownik", autor);
        }

        public IActionResult WidokLogowania() {
            return View("WidokLogowania");
        }

        //[HttpPost] public IActionResult LoginUser(User user) {

        //}
    }
}
