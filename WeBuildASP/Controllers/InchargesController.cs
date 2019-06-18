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
    public class InchargesController : Controller
    {

        //Dependency for IncgargeService
        private readonly InchargeService _inchargeService;
        private readonly UserService _userService;

        //Construct for dependency
        public InchargesController(InchargeService inchargeService, UserService userService)
        {
            _inchargeService = inchargeService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            //Receive list from method Find All
            var list = _inchargeService.FindAll();
            return View(list);
        }

        //Action to back in page
        public IActionResult GoAdminMenu()
        {
            return RedirectToAction("AdminMenu", "Home");
        }

        //Return to create Incharger page
        public IActionResult Create()
        {
            //Load Users from Database
            var users = _userService.FindIncharges();
            var viewModel = new InchargeFormViewModel { Users = users };

            return View(viewModel);
        }

        //Create Incharger Action
        [HttpPost]
        public IActionResult Create(Incharge incharge)
        {
            _inchargeService.Insert(incharge); //Insert new Incharge

            //Redirect to Index Page
            return RedirectToAction(nameof(Index));
        }

        //Return values of Incharger in page   
        public IActionResult Delete(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Load object for delete
            var obj = _inchargeService.FindById(id.Value);

            //Testif id exists
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Action for delete incharges
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _inchargeService.remove(id);
            return RedirectToAction(nameof(Index));
        }

        //Action for Incharger Details - Return values of Incharger in page  
        public IActionResult Details(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Load object for delete
            var obj = _inchargeService.FindById(id.Value);

            //Testif id exists
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Action for edit Encharges
        public IActionResult Edit(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Test if id exists
            var obj = _inchargeService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            //Open Edit Screen
            List<User> users = _userService.FindAll();
            InchargeFormViewModel viewModel = new InchargeFormViewModel { Incharge = obj, Users = users };

            //Return view
            return View(viewModel);
        }

        //Edit action
        [HttpPost]
        public IActionResult Edit(int id, Incharge incharge)
        {
            //Test if Id on method is different than incharge id
            if (id != incharge.ID)
            {
                return BadRequest();
            }

            //If is all Ok
            _inchargeService.Update(incharge);

            //Return to index
            return RedirectToAction(nameof(Index));
        }
    }
}