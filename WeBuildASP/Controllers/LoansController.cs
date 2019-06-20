using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeBuildASP.Models;
using WeBuildASP.Models.ViewModels;
using WeBuildASP.Services;

namespace WeBuildASP.Controllers
{
    public class LoansController : Controller
    {

        //Dependency for LoanService
        private readonly LoanService _loanService;
        private readonly TeamService _teamService;

        //Construct for dependency
        public LoansController(LoanService loanService, TeamService teamService)
        {
            _loanService = loanService;
            _teamService = teamService;
        }


        public IActionResult Index()
        {
            //Receive list from method Find All
            var list = _loanService.FindAll();
            return View(list);
        }

        //Action to back in page
        public IActionResult GoAdminMenu()
        {
            return RedirectToAction("AdminMenu", "Home");
        }

        //Return to create Loan page
        public IActionResult Create()
        {
            //Load Loans from Database
            var teams = _teamService.FindAll();
            var viewModel = new LoanFormViewModel { Teams = teams };

            return View(viewModel);
        }

        //Create Loan Action
        [HttpPost]
        public IActionResult Create(Loan loan)
        {
            _loanService.Insert(loan); //Insert new loan

            //Redirect to Index Page
            return RedirectToAction(nameof(Index));
        }

        //Return values of Loans in page   
        public IActionResult Delete(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Load object for delete
            var obj = _loanService.FindById(id.Value);

            //Testif id exists
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Action for delete Loans
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _loanService.remove(id);
            return RedirectToAction(nameof(Index));
        }

        //Action for loan Details - Return values of loans in page  
        public IActionResult Details(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Load object for delete
            var obj = _loanService.FindById(id.Value);

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
            var obj = _loanService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            //Open Edit Screen
            List<Team> teams = _teamService.FindAll();
            LoanFormViewModel viewModel = new LoanFormViewModel { Loan = obj, Teams = teams };

            //Return view
            return View(viewModel);
        }

        //Edit action
        [HttpPost]
        public IActionResult Edit(int id, Loan loan)
        {
            //Test if Id on method is different than loan id
            if (id != loan.ID)
            {
                return BadRequest();
            }

            //If is all Ok
            _loanService.Update(loan);

            //Return to index
            return RedirectToAction(nameof(Index));
        }
    }
}