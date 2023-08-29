using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ZarzadzaniePrzedsiebiorstwem.Services.Interfaces;
using ZarzadzaniePrzedsiebiorstwem.Model.Authentication;
using ZarzadzaniePrzedsiebiorstwem.Model.DataModels;
using ZarzadzaniePrzedsiebiorstwem.ViewModels.ViewModels;
using ZarzadzaniePrzedsiebiorstwem.Services.Services;

namespace ZarzadzaniePrzedsiebiorstwem.Web.Controllers {
    public class CompanyController : Controller {
        private readonly IUserService _userService;
        private readonly IPrzedsiebiorstwoService _przedsiebiorstwoService;

        public CompanyController(IUserService userService, IPrzedsiebiorstwoService przedsiebiorstwoService) {
            _userService = userService;
            _przedsiebiorstwoService = przedsiebiorstwoService;
        }

        public IActionResult AddCompanyView(int id) {

            var emptyCompany = new Przedsiebiorstwo();
            var user = _userService.GetUserFromId(id);
            Console.WriteLine(user.Login);
            var addCompanyViewModel = new AddCompanyViewModel {
                User = user,
                Przedsiebiorstwo = emptyCompany
            };
            Console.WriteLine(addCompanyViewModel.User.Haslo);
            return View("AddCompanyView", addCompanyViewModel);
        }

        [HttpPost]
        public IActionResult RegisterCompany(AddCompanyViewModel addCompanyViewModel) {
            var user = _userService.GetUserFromId(addCompanyViewModel.Przedsiebiorstwo.UserId);

            var newCompany = new Przedsiebiorstwo {
                NazwaSkrocona = addCompanyViewModel.Przedsiebiorstwo.NazwaSkrocona,
                NazwaPelna = addCompanyViewModel.Przedsiebiorstwo.NazwaPelna,
                NIP = addCompanyViewModel.Przedsiebiorstwo.NIP,
                REGON = addCompanyViewModel.Przedsiebiorstwo.REGON,
                daneAdresowe = addCompanyViewModel.Przedsiebiorstwo.daneAdresowe,
                PowiatGmina = addCompanyViewModel.Przedsiebiorstwo.PowiatGmina,
                Wojewodztwo = addCompanyViewModel.Przedsiebiorstwo.Wojewodztwo,
                RachunekBankowy = addCompanyViewModel.Przedsiebiorstwo.RachunekBankowy,
                FormaPrawna = addCompanyViewModel.Przedsiebiorstwo.FormaPrawna,
                User = user,
                UserId = addCompanyViewModel.Przedsiebiorstwo.Id,
            };
            addCompanyViewModel.Przedsiebiorstwo.User = user;
            addCompanyViewModel.User = user;
            _userService.RegisterCompany(newCompany);

            return View("Views/Company/CompanyDashboard.cshtml", addCompanyViewModel);
        }

        public IActionResult ViewSettings(int id) {
            var sessionId = Int32.Parse(_userService.GetSessionIdFromCookie());
            var user = _userService.GetUserFromId(id);
            if (id != sessionId) {
                return View("Views/User/WidokAutoryzowany.cshtml", user);
            }

            var companyViewModel = new AddCompanyViewModel {
                User = _userService.GetUserFromId(id),
                Przedsiebiorstwo = _przedsiebiorstwoService.GetPrzedsiebiorstwoFromUserId(id)
            };

            return View("Views/User/UserSettings.cshtml", companyViewModel);
        }

        public IActionResult ViewDashboard(int id) {
            var user = _userService.GetUserFromId(id);
            return View("Views/User/WidokAutoryzowany.cshtml", user);
        }
    }
}
