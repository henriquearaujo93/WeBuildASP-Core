using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeBuildASP.Models;
using WeBuildASP.Models.ViewModels;
using WeBuildASP.Services;

namespace WeBuildASP.Controllers
{
    public class SchedulesController : Controller
    {

        //Dependency for Schedule Service
        private readonly ScheduleService _scheduleService;
        private readonly TeamService _teamService;

        //Construct for dependency
        public SchedulesController(ScheduleService scheduleService, TeamService teamService)
        {
            _scheduleService = scheduleService;
            _teamService = teamService;
        }

        public IActionResult Index()
        {
            //Receive list from method Find All
            var list = _scheduleService.FindAll();
            return View(list);
        }

        //Action to back in page
        public IActionResult GoAdminMenu()
        {
            return RedirectToAction("AdminMenu", "Home");
        }

        //Return to create Schedule page
        public IActionResult Create()
        {
            //Load Teams from Database
            var teams = _teamService.FindAll();
            var viewModel = new ScheduleFormViewModel { Teams = teams };

            return View(viewModel);
        }

        //Create Schedule Action
        [HttpPost]
        public IActionResult Create(Schedule schedule)
        {
            _scheduleService.Insert(schedule); //Insert new team

            //Redirect to Index Page
            return RedirectToAction(nameof(Index));
        }
    }
}