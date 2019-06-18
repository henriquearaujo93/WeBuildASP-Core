using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeBuildASP.Models;
using WeBuildASP.Models.ViewModels;
using WeBuildASP.Services;

namespace WeBuildASP.Controllers
{
    public class EmployeesController : Controller
    {

        //Dependency for EmployeeService
        private readonly EmployeeService _employeeService;
        private readonly TeamService _teamService;

        //Construct for dependency
        public EmployeesController(EmployeeService employeeService, TeamService teamService)
        {
            _employeeService = employeeService;
            _teamService = teamService;
        }

        public IActionResult Index()
        {
            //Receive list from method Find All
            var list = _employeeService.FindAll();
            return View(list);
        }

        //Action to back in page
        public IActionResult GoAdminMenu()
        {
            return RedirectToAction("AdminMenu", "Home");
        }

        //Return to create Employee page
        public IActionResult Create()
        {
            //Load Users from Database
            var teams = _teamService.FindAll();
            var viewModel = new EmployeeFormViewModel { Teams = teams };

            return View(viewModel);
        }

        //Create Employee Action
        [HttpPost]
        public IActionResult Create(Employee employee, IFormFile Image)
        {
            if (ModelState.IsValid)
            {
                //Verify if image is null
                if (Image != null)
                {
                    byte[] img;

                    //Open Image
                    using (var or = Image.OpenReadStream())
                    {
                        //Copy image to memory
                        using (var ms = new MemoryStream())
                        {
                            or.CopyTo(ms);

                            //Convert to Byte
                            img = ms.ToArray();
                        }
                    }
                    employee.E_IMAGE = img;
                }
                else
                {
                    GetImage(employee.ID);
                }
            }

            _employeeService.Insert(employee); //Insert new Employee

            //Redirect to Index Page
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        //Method to get image
        public IActionResult GetImage(int id)
        {
            byte[] img = _employeeService.FindById(id).E_IMAGE;

            if (img != null)
            {
                return File(img, "image/jpg");
            }
            else
            {
                return null;
            }
        }

        //Return values of Employee in page   
        public IActionResult Delete(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Load object for delete
            var obj = _employeeService.FindById(id.Value);

            //Test if id exists
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Action for delete Employees
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _employeeService.remove(id);
            return RedirectToAction(nameof(Index));
        }

        //Action for Employes Details - Return values of Employes in page  
        public IActionResult Details(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Load object for delete
            var obj = _employeeService.FindById(id.Value);

            //Testif id exists
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Action for edit Employees
        public IActionResult Edit(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Test if id exists
            var obj = _employeeService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            //Open Edit Screen
            List<Team> teams = _teamService.FindAll();
            EmployeeFormViewModel viewModel = new EmployeeFormViewModel { Employee = obj, Teams = teams };

            //Return view
            return View(viewModel);
        }

        //Edit action
        [HttpPost]
        public IActionResult Edit(int id, Employee employee, IFormFile Image)
        {
            //Test if Id on method is different than employee id
            if (id != employee.ID)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                //Verify if image is null
                if (Image != null)
                {
                    byte[] img;

                    //Open Image
                    using (var or = Image.OpenReadStream())
                    {
                        //Copy image to memory
                        using (var ms = new MemoryStream())
                        {
                            or.CopyTo(ms);

                            //Convert to Byte
                            img = ms.ToArray();
                        }
                    }
                    employee.E_IMAGE = img;
                }
            }

            //If is all Ok
            _employeeService.Update(employee);

            //Return to index
            return RedirectToAction(nameof(Index));
        }
    }
}