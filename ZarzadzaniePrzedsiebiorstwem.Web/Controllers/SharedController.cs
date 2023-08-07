using Microsoft.AspNetCore.Mvc;
using System;

namespace ZarzadzaniePrzedsiebiorstwem.Web.Controllers {
	public class SharedController : Controller {
		public IActionResult AuthenticationStatus() {
			return PartialView("_AuthenticationStatus");
		}
	}
}
