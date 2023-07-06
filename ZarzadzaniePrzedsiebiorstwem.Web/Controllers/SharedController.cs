using Microsoft.AspNetCore.Mvc;

namespace ZarzadzaniePrzedsiebiorstwem.Web.Controllers {
	public class SharedController : Controller {
		public IActionResult AuthenticationStatus() {
			return PartialView("Partials/_AuthenticationStatus");
		}
	}
}
