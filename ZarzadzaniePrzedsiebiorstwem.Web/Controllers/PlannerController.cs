﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ZarzadzaniePrzedsiebiorstwem.Services.Interfaces;
using ZarzadzaniePrzedsiebiorstwem.Model.Authentication;
using ZarzadzaniePrzedsiebiorstwem.Model.DataModels;
using ZarzadzaniePrzedsiebiorstwem.ViewModels.ViewModels;
using ZarzadzaniePrzedsiebiorstwem.Services.Services;

namespace ZarzadzaniePrzedsiebiorstwem.Web.Controllers {
    public class PlannerController : Controller {
        private readonly IUserService _userService;
        private readonly IPlannerService _plannerService;

        public PlannerController(IUserService userService, IPlannerService plannerService) {
            _userService = userService;
            _plannerService = plannerService;
        }

        public IActionResult Index(int Id) {
            var plannerExists = _plannerService.GetPlannerBool(Id);

            if (plannerExists == false) {
                _plannerService.CreatePlanner(Id);
            }

            var user = _userService.GetUserFromId(Id);
            return View("Views/Planner/Planning.cshtml", user);
        }
    }
}