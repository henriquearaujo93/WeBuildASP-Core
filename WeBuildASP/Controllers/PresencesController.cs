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
    public class PresencesController : Controller
    {

        //Dependency for PresenceService
        private readonly PresenceService _presenceService;
        private readonly EmployeeService _employeeService;

        //Construct for dependency
        public PresencesController(PresenceService presenceService, EmployeeService employeeService)
        {
            _presenceService = presenceService;
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            //Receive list from method Find All
            var list = _presenceService.FindAll();
            return View(list);
        }

        //Action to back in page
        public IActionResult GoAdminMenu()
        {
            return RedirectToAction("AdminMenu", "Home");
        }

        //Return to create Presence page
        public IActionResult Create()
        {
            //Load Employees from Database
            var employees = _employeeService.FindAll();
            var viewModel = new PresenceFormViewModel { Employees = employees };

            return View(viewModel);
        }

        //Create Presence Action
        [HttpPost]
        public IActionResult Create(Presence presence)
        {
            
            _presenceService.Insert(presence); //Insert new Presence

            //Redirect to Index Page
            return RedirectToAction(nameof(Index));
        }

        //Return values of Presences in page   
        public IActionResult Delete(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Load object for delete
            var obj = _presenceService.FindById(id.Value);

            //Testif id exists
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Action for delete Presences
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _presenceService.remove(id);
            return RedirectToAction(nameof(Index));
        }

        //Action for Presences Details - Return values of Presence in page  
        public IActionResult Details(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Load object for delete
            var obj = _presenceService.FindById(id.Value);

            //Testif id exists
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Action for edit Presences
        public IActionResult Edit(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Test if id exists
            var obj = _presenceService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            //Open Edit Screen
            List<Employee> employees = _employeeService.FindAll();
            var viewModel = new PresenceFormViewModel { Presence = obj, Employees = employees };

            //Return view
            return View(viewModel);
        }

        //Edit action
        [HttpPost]
        public IActionResult Edit(int id, Presence presence)
        {
            //Test if Id on method is different than Presence id
            if (id != presence.ID)
            {
                return BadRequest();
            }

            //If is all Ok
            _presenceService.Update(presence);

            //Return to index
            return RedirectToAction(nameof(Index));
        }
    }
}