using Microsoft.AspNetCore.Mvc;
using ZarzadzaniePrzedsiebiorstwem.Model.Authentication;

namespace ZarzadzaniePrzedsiebiorstwem.Web.Controllers {
    public class UserController : Controller {
        public IActionResult Index() {
            return View();
        }

        public IActionResult WidokRejestracji() {
            return View("WidokRejestracji");
        }

        [HttpPost] public IActionResult RegisterAccount(User user) {
            return RedirectToAction("RegisteredAccount", "User");
        }
    }
}
