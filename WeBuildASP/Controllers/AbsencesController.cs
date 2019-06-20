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
    public class AbsencesController : Controller
    {
        //Dependency for AbsenceService
        private readonly AbsenceService _absenceService;
        private readonly EmployeeService _employeeService;

        //Construct for dependency
        public AbsencesController(AbsenceService absenceService, EmployeeService employeeService)
        {
            _absenceService = absenceService;
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            //Receive list from method Find All
            var list = _absenceService.FindAll();
            return View(list);
        }

        //Action to back in page
        public IActionResult GoAdminMenu()
        {
            return RedirectToAction("AdminMenu", "Home");
        }

        //Return values of Absence in page   
        public IActionResult Delete(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Load object for delete
            var obj = _absenceService.FindById(id.Value);

            //Testif id exists
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Action for delete Absence
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _absenceService.remove(id);
            return RedirectToAction(nameof(Index));
        }

        //Action for Absence Details - Return values of Absence in page  
        public IActionResult Details(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Load object for delete
            var obj = _absenceService.FindById(id.Value);

            //Testif id exists
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Action for edit Absence
        public IActionResult Edit(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Test if id exists
            var obj = _absenceService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            //Open Edit Screen
            List<Employee> employees = _employeeService.FindAll();
            AbsenceFormViewModel viewModel = new AbsenceFormViewModel { Absence = obj, Employees = employees };

            //Return view
            return View(viewModel);
        }

        //Edit action
        [HttpPost]
        public IActionResult Edit(int id, Absence absence)
        {
            //Test if Id on method is different than absence id
            if (id != absence.ID)
            {
                return BadRequest();
            }

            //If is all Ok
            _absenceService.Update(absence);

            //Return to index
            return RedirectToAction(nameof(Index));
        }
    }
}