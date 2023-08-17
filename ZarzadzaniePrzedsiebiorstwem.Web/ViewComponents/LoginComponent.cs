using Microsoft.AspNetCore.Mvc;
using ZarzadzaniePrzedsiebiorstwem.Model.Authentication;

namespace ZarzadzaniePrzedsiebiorstwem.Web.ViewComponents {
    public class LoginComponent : ViewComponent {
        public IViewComponentResult Invoke(User user) {
            return View(user);
        }
    }
}
