using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ZarzadzaniePrzedsiebiorstwem.Services.Interfaces;
using ZarzadzaniePrzedsiebiorstwem.Model.Authentication;
using ZarzadzaniePrzedsiebiorstwem.Model.DataModels;
using ZarzadzaniePrzedsiebiorstwem.ViewModels.ViewModels;

namespace ZarzadzaniePrzedsiebiorstwem.Web.Controllers {
    public class CompanyController : Controller {

        private readonly IUserService userService;

        public CompanyController(IUserService userService) {
            this.userService = userService;
        }

        public IActionResult AddCompanyView(User user) {

            var emptyCompany = new Przedsiebiorstwo();

            var addCompanyViewModel = new AddCompanyViewModel {
                User = user,
                Przedsiebiorstwo = emptyCompany
            };
            return View("AddCompanyView", addCompanyViewModel);
        }
    }
}
