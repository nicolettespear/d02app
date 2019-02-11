using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Title"] = "Information on A.A.";

            return View();
        }
        public IActionResult Meetings()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult IsItForMe()
        {
            return View();
        }
        public IActionResult StepsTraditions()
        {
            return View();
        }
        public IActionResult Events()
        {
            return View();
        }
        public IActionResult Forms()
        {
            return View();
        }
        public IActionResult Service()
        {
            return View();
        }
        public IActionResult Links()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
