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

        //Return values of Schedule in page   
        public IActionResult Delete(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Load object for delete
            var obj = _scheduleService.FindById(id.Value);

            //Testif id exists
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Action for delete Schedules
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _scheduleService.remove(id);
            return RedirectToAction(nameof(Index));
        }

        //Action for Schedule Details - Return values of Schedule in page  
        public IActionResult Details(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Load object for delete
            var obj = _scheduleService.FindById(id.Value);

            //Testif id exists
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Action for edit Schedules
        public IActionResult Edit(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Test if id exists
            var obj = _scheduleService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            //Open Edit Screen
            List<Team> teams = _teamService.FindAll();
            ScheduleFormViewModel viewModel = new ScheduleFormViewModel { Schedule = obj, Teams = teams };

            //Return view
            return View(viewModel);
        }

        //Edit action
        [HttpPost]
        public IActionResult Edit(int id, Schedule schedule)
        {
            //Test if Id on method is different than schedule id
            if (id != schedule.ID)
            {
                return BadRequest();
            }

            //If is all Ok
            _scheduleService.Update(schedule);

            //Return to index
            return RedirectToAction(nameof(Index));
        }
    }
}