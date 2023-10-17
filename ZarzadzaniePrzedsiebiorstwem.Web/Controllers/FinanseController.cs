﻿using Microsoft.AspNetCore.Mvc;
using ZarzadzaniePrzedsiebiorstwem.Model.Authentication;
using ZarzadzaniePrzedsiebiorstwem.Model.DataModels.Planner;
using ZarzadzaniePrzedsiebiorstwem.Model.DataModels.SprawozdaniaFinansowe;
using ZarzadzaniePrzedsiebiorstwem.Services.Interfaces;
using ZarzadzaniePrzedsiebiorstwem.Services.Services;

namespace ZarzadzaniePrzedsiebiorstwem.Web.Controllers {
    public class FinanseController : Controller {
        private readonly IUserService _userService;
        private readonly IFinanseService _finanseService;

        public FinanseController(IUserService userService, IFinanseService finanseService) {
            _userService = userService;
            _finanseService = finanseService;
        }

        public IActionResult WyswietlRozliczenia(int id) {
            var user = _userService.GetUserFromId(id);
            return View("~/Views/Finanse/WyswietlRozliczenia.cshtml", user);
        }

        public IActionResult DodajRachunekZyskowIStrat(int id) {
            var user = _userService.GetUserFromId(id);
            return View("~/Views/Finanse/DodajRachunekZyskowIStrat.cshtml", user);
        }

        [HttpPost]
        public IActionResult DodajRachunekDoBazy(RachunekZyskowIStrat rachunekZyskowIStrat) {
            var user = _userService.GetUserFromId(rachunekZyskowIStrat.UserId);
            _finanseService.AddRachunekZyskowIStratToDb(rachunekZyskowIStrat);

            var newViewUrl = Url.Action("WyswietlRozliczenia", new { id = rachunekZyskowIStrat.UserId });
            return Json(new { redirectUrl = newViewUrl });
        }

        public IActionResult WyswietlRachunekZyskowIStrat(int id) {
            var rachunekZyskowIStrat = _finanseService.GetRachunekZyskowIStratFromDb(id);
            return View("~/Views/Finanse/WyswietlRachunekZyskowIStrat.cshtml", rachunekZyskowIStrat);
        }
    }
}
