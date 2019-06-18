using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeBuildASP.Models;

namespace WeBuildASP.Controllers
{
    public class AcessController : Controller
    {
        public IActionResult Index()
        {
            //List of acess
            List<Acess> list = new List<Acess>();

            return View();
        }
    }
}