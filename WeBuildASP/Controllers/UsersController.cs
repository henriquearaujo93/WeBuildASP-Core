using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeBuildASP.Services;
using WeBuildASP.Models;
using WeBuildASP.Models.ViewModels;
using System.Data;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace WeBuildASP.Controllers
{
    public class UsersController : Controller
    {
        //Function Find All from UsersService
        private readonly UserService _usersService;
        private readonly AcessService _acessService;

        //Construct for instance
        public UsersController(UserService usersService, AcessService acessService)
        {
            _usersService = usersService;
            _acessService = acessService;
        }

        public IActionResult Index()
        {
            //Receive list from function Find All
            var list = _usersService.FindAll();

            return View(list);
        }

        //Action to back in page
        public IActionResult GoAdminMenu()
        {
            return RedirectToAction("AdminMenu", "Home");
        }

        //Action for user login
        public IActionResult Login(int? id)
        {
            if (id != null)
            {
                if (id == 0)
                {
                    HttpContext.Session.SetString("LoggedUsername", string.Empty);
                    HttpContext.Session.SetString("LoggedId", string.Empty);
                }
            }

            return View();
        }

        //Action for validate Login
        [HttpPost]
        public IActionResult ValidateLogin(User user)
        {
            string username = user.U_USERNAME;
            string password = user.U_PASSWORD;
            int id = user.ID;

            var check = _usersService.FindByUserandPass(username, password);

            if (check != null)
            {
                if (check.U_ACESS == "A")
                {
                    HttpContext.Session.SetString("LoggedUsername", username);
                    HttpContext.Session.SetString("LoggedId", id.ToString());
                    return RedirectToAction("AdminMenu", "Home");
                }
                else if (check.U_ACESS == "M")
                {
                    HttpContext.Session.SetString("LoggedUsername", username);
                    HttpContext.Session.SetString("LoggedId", id.ToString());
                    return RedirectToAction("ManagerMenu", "Home");
                }

                else
                {
                    @TempData["PermissionDenied"] = "You do not have permission to enter!";
                    return RedirectToAction("Login", "Users");
                }
            }
            else
            {
                @TempData["InvalidLoginMessage"] = "Invalid Username Or Password!";
                return RedirectToAction("Login", "Users");
            }
        }

        //Return to create user page
        public IActionResult Create()
        {
            //Load Acess from DataBase
            var acess = _acessService.FindAll();
            var viewModel = new UserFormViewModel { Acess = acess };

            return View(viewModel);
        }

        //action to create new user
        [HttpPost]
        public IActionResult Create(User user)
        {
            _usersService.Insert(user); //Insert new user             
            return RedirectToAction(nameof(Index)); //Return to user page index
        }

        //Return values of user in page   
        public IActionResult Delete(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Load object for delete
            var obj = _usersService.FindById(id.Value);

            //Testif id exists
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Action for delete user
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _usersService.remove(id);
            return RedirectToAction(nameof(Index));
        }

        //Action for User Details - Return values of user in page  
        public IActionResult Details(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Load object for delete
            var obj = _usersService.FindById(id.Value);

            //Testif id exists
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Action for edit users
        public IActionResult Edit(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Test if id exists
            var obj = _usersService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            //Open Edit Screen
            List<Acess> acesses = _acessService.FindAll();
            UserFormViewModel viewModel = new UserFormViewModel { User = obj, Acess = acesses };

            //Return view
            return View(viewModel);
        }

        //Edit action
        [HttpPost]
        public IActionResult Edit(int id, User user)
        {
            //Test if Id on method is different than user id
            if (id != user.ID)
            {
                return BadRequest();
            }

            //If is all Ok
            _usersService.Update(user);

            //Return to index
            return RedirectToAction(nameof(Index));
        }
    }
}