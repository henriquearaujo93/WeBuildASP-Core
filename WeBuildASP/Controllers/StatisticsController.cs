using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeBuildASP.Models;

namespace WeBuildASP.Controllers
{
    public class StatisticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Action to back in page
        public IActionResult GoAdminMenu()
        {
            return RedirectToAction("AdminMenu", "Home");
        }
    }
}