using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace ZarzadzaniePrzedsiebiorstwem.Web.Controllers {
    public class CompanyController : Controller {

        public IActionResult AddCompanyView() {         
            return View("AddCompanyView");
        }
    }
}
