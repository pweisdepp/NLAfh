using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NLAfh.Models;

namespace NLAfh.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OurHomes()
        {
                ViewData["Message"] = "Our homes";

                return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();

        }

        public IActionResult Photos()
        {
            ViewData["Message"] = "Photos";

            return View();
        }

        public IActionResult Services()
        {
            ViewData["Message"] = "Services";

            return View();
        }

        public IActionResult Mission()
        {
            ViewData["Message"] = "Mission";

            return View();
        }

        public IActionResult Advantage()
        {
            ViewData["Message"] = "Advantage";

            return View();
        }

        public IActionResult Info()
        {
            ViewData["Message"] = "Info";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
