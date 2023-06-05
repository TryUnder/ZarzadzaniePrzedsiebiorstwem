using Microsoft.AspNetCore.Mvc;

namespace ZarzadzaniePrzedsiebiorstwem.Web.Controllers {
    public class UserController : Controller {
        public IActionResult Index() {
            return View();
        }

        public IActionResult WidokRejestracji() {
            return View("WidokRejestracji");
        }
    }
}
