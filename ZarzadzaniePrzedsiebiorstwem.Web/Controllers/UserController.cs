using Microsoft.AspNetCore.Mvc;
using ZarzadzaniePrzedsiebiorstwem.Model.Authentication;
using ZarzadzaniePrzedsiebiorstwem.Services.Interfaces;

namespace ZarzadzaniePrzedsiebiorstwem.Web.Controllers {
    public class UserController : Controller {

        private readonly IRegisterAccount _registerAccount;

        public UserController(IRegisterAccount registerAccount) {
            _registerAccount = registerAccount;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult WidokRejestracji() {
            return View("WidokRejestracji");
        }

        [HttpPost] public IActionResult RegisterAccount(User user) {
            var autor = _registerAccount.RegisterAccount(user);
            return View("ZarejestrowanyUzytkownik", autor);
        }
    }
}
