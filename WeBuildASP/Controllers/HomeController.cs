using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeBuildASP.Models;

namespace WeBuildASP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This is a short description of what We Build dows and how it works";
            ViewData["Description"] = "WeBuild is a company that works with constructions, this company don´t have any place that we can call the center of the company, they work arround the globe.This web page is one of the WeBuild property, if you aren´t a WeBuild manager or administrator you can´t login in to this web page!Thank you for your visit, if you are interested in contact us please consult our main web site for the customers!";
            ViewData["Company"] = "Programming is Art";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new WeBuildASP.Models.ViewModels.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //Action for Menu Page
        public IActionResult AdminMenu()
        {
            return View();
        }

        //Action for Menu Page
        public IActionResult ManagerMenu()
        {
            return View();
        }
    }
}

