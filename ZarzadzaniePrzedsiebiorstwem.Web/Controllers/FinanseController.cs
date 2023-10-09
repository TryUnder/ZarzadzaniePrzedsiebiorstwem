﻿using Microsoft.AspNetCore.Mvc;
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
    }
}
