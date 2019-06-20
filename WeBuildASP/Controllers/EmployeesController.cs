using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        //Statistics
        //Top 5 Lates Employ
        public IActionResult Top5LatesEmploy()
        {
            List<Employee> employees = new List<Employee>();

            //Receive list of top 5 employees
            string sql = "SELECT EMPLOYS.ID, E_NAME, E_LASTANAME, E_NACIONALITY, E_DTANAS, E_TEAM, E_ACTIVE FROM EMPLOYS INNER JOIN PRESENCE ON P_EMPLOY = EMPLOYS.ID INNER JOIN TEAM ON EMPLOYS.E_TEAM = TEAM.ID INNER JOIN SCHEDULE ON SCHEDULE.S_TEAM = TEAM.ID WHERE SCHEDULE.S_STARTT != CONVERT(TIME, PRESENCE.P_REGISTERENTRY) ORDER BY PRESENCE.P_REGISTERENTRY DESC";

            string connectionString = "Data Source = webuild.database.windows.net; Initial Catalog = webuilddb; User ID = programmingisart; Password = programming2U; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            using(SqlConnection cnn = new SqlConnection(connectionString))
            {
                using(SqlCommand cmm = new SqlCommand(sql, cnn))
                {
                    cnn.Open();

                    using(SqlDataReader reader = cmm.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            employees.Add(new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetBoolean(6)));
                        }
                    }
                }
            }

            List<Employee> employees1 = new List<Employee>();

            for (int i = 0; i < 5; i++)
            {
                employees1.Add(new Employee(employees[i].ID, employees[i].E_NAME, employees[i].E_LASTANAME, employees[i].E_NACIONALITY, employees[i].E_DTANAS, employees[i].E_ACTIVE));
            }

            employees.Clear();

            return View(employees1);
        }

        //Top 5 Employ that asked for money
        public IActionResult Top5EmployThatAskedMoney()
        {
            List<LoanForEmploy> loanForEmploys = new List<LoanForEmploy>();

            //Receive list of top 5 employees
            string sql = "SELECT EMPLOYS.ID , LOAN_FOR_EMPLOY.L_F_AMOUNT , L_F_EMPLOY  FROM LOAN_FOR_EMPLOY INNER JOIN EMPLOYS ON EMPLOYS.ID = LOAN_FOR_EMPLOY.L_F_EMPLOY";

            string connectionString = "Data Source = webuild.database.windows.net; Initial Catalog = webuilddb; User ID = programmingisart; Password = programming2U; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmm = new SqlCommand(sql, cnn))
                {
                    cnn.Open();

                    using (SqlDataReader reader = cmm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            loanForEmploys.Add(new LoanForEmploy(reader.GetInt32(0), reader.GetFloat(1), reader.GetInt32(2)));
                        }
                    }
                }
            }

            List<LoanForEmploy> loansForEmploys1 = new List<LoanForEmploy>();

            for (int i = 0; i < 5; i++)
            {
                loansForEmploys1.Add(new LoanForEmploy(loanForEmploys[i].ID, loanForEmploys[i].L_F_AMOUNT, loanForEmploys[i].L_F_EMPLOY));
            }

            loanForEmploys.Clear();

            return View(loansForEmploys1);
        }

    }
}