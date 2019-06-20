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
    public class TeamsController : Controller
    {

        //Dependency for TeamService
        private readonly TeamService _teamService;
        private readonly InchargeService _inchargeService;

        //Construct for dependency
        public TeamsController(TeamService teamService, InchargeService inchargeService)
        {
            _teamService = teamService;
            _inchargeService = inchargeService;
        }

        public IActionResult Index()
        {
            //Receive list from method Find All
            var list = _teamService.FindAll();
            return View(list);
        }

        //Action to back in page
        public IActionResult GoAdminMenu()
        {
            return RedirectToAction("AdminMenu", "Home");
        }

        //Return to create Team page
        public IActionResult Create()
        {
            //Load Incharges from Database
            var incharges = _inchargeService.FindAll();
            var viewModel = new TeamFormViewModel { Incharges = incharges };

            return View(viewModel);
        }

        //Create Team Action
        [HttpPost]
        public IActionResult Create(Team team)
        {
            _teamService.Insert(team); //Insert new team

            //Redirect to Index Page
            return RedirectToAction(nameof(Index));
        }

        //Return values of Teams in page   
        public IActionResult Delete(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Load object for delete
            var obj = _teamService.FindById(id.Value);

            //Testif id exists
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Action for delete Teams
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _teamService.remove(id);
            return RedirectToAction(nameof(Index));
        }

        //Action for Team Details - Return values of Teams in page  
        public IActionResult Details(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Load object for delete
            var obj = _teamService.FindById(id.Value);

            //Testif id exists
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Action for edit Teams
        public IActionResult Edit(int? id)
        {
            //Test if id is null
            if (id == null)
            {
                return NotFound();
            }

            //Test if id exists
            var obj = _teamService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            //Open Edit Screen
            List<Incharge> incharges = _inchargeService.FindAll();
            TeamFormViewModel viewModel = new TeamFormViewModel { Team = obj, Incharges = incharges };

            //Return view
            return View(viewModel);
        }

        //Edit action
        [HttpPost]
        public IActionResult Edit(int id, Team team)
        {
            //Test if Id on method is different than team id
            if (id != team.ID)
            {
                return BadRequest();
            }

            //If is all Ok
            _teamService.Update(team);

            //Return to index
            return RedirectToAction(nameof(Index));
        }

        //Statistics
        //Top 5 Countrys that asked for money
        public IActionResult Top5CountrysMoney()
        {
            List<Team> teams = new List<Team>();

            //Receive list of top 5 Countrys
            string sql = "SELECT TEAM.ID, TEAM.T_COUNTRY FROM TEAM INNER JOIN EMPLOYS ON EMPLOYS.E_TEAM = TEAM.ID INNER JOIN LOAN_FOR_EMPLOY ON EMPLOYS.ID = LOAN_FOR_EMPLOY.L_F_EMPLOY ORDER BY LOAN_FOR_EMPLOY.L_F_AMOUNT";

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
                            teams.Add(new Team(reader.GetInt32(0), reader.GetString(1)));
                        }
                    }
                }
            }

            List<Team> teams1 = new List<Team>();

            for (int i = 0; i < 5; i++)
            {
                teams1.Add(new Team(teams[i].ID, teams[i].T_COUNTRY));
            }

            teams.Clear();

            return View(teams1);
        }
    }
}