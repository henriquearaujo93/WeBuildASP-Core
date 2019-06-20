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
    public class LoanForEmploysController : Controller
    {
        //Dependency for LoanService
        private readonly LoanForEmployService _loanForEmployService;
        private readonly EmployeeService _employeeService;

        //Construct for dependency
        public LoanForEmploysController(LoanForEmployService loanForEmployService, EmployeeService employeeService)
        {
            _loanForEmployService = loanForEmployService;
            _employeeService = employeeService;
        }


        public IActionResult Index()
        {
            //Receive list from method Find All
            var list = _loanForEmployService.FindAll();
            return View(list);
        }

        //Action to back in page
        public IActionResult GoAdminMenu()
        {
            return RedirectToAction("AdminMenu", "Home");
        }

        //Action for Loans Details - Return values of Loans in page  
        public IActionResult Details(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Load object for delete
            var obj = _loanForEmployService.FindById(id.Value);

            //Testif id exists
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Action for edit Loans
        public IActionResult Edit(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Test if id exists
            var obj = _loanForEmployService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            //Open Edit Screen
            List<Employee> employees = _employeeService.FindAll();
            LoanForEmployFormViewModel viewModel = new LoanForEmployFormViewModel { LoanForEmploy = obj, Employs = employees };

            //Return view
            return View(viewModel);
        }

        //Edit action
        [HttpPost]
        public IActionResult Edit(int id, LoanForEmploy loanForEmploy)
        {
            //Test if Id on method is different than loan id
            if (id != loanForEmploy.ID)
            {
                return BadRequest();
            }

            //If is all Ok
            _loanForEmployService.Update(loanForEmploy);

            //Return to index
            return RedirectToAction(nameof(Index));
        }

        public double Avarage()
        {
            var obj = _loanForEmployService.Average();

            return obj;
        }
    }
}