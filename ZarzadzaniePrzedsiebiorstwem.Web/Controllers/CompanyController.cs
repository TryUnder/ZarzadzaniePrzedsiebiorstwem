﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ZarzadzaniePrzedsiebiorstwem.Services.Interfaces;

namespace ZarzadzaniePrzedsiebiorstwem.Web.Controllers {
    public class CompanyController : Controller {

        private readonly IUserService userService;

        public CompanyController(IUserService userService) {
            this.userService = userService;
        }

        public IActionResult AddCompanyView(int id) { 
            System.Console.WriteLine("Id: ", id);
            return View("AddCompanyView");
        }
    }
}