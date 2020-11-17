using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CountriesStateManagementLab.Models;

namespace CountriesStateManagementLab.Controllers
{
    public class HomeController : Controller
    {
        public List<Country> countries = new List<Country>()
            {
                new Country("USA", "English", "Hello world!", "We like guns", new List<string> {"red", "white", "blue" } ),
                new Country("Mexico", "Spanish", "Hola Mundo!", "High schoolers come here for spring break", new List<string> {"green", "white", "red" } ),
                new Country("Japan", "Japanese", "Kon'nichiwa sekai! Nani?!", "Anime food looks better than food in real life", new List<string> {"red", "white"} ),
                new Country("France", "French", "Bonjour le monde!", "Escargot, anyone?", new List<string> {"blue", "white", "red" }),
                new Country("Greece", "Greek", "Geia sou Kosme!", "This place is highly Instagrammable", new List<string> {"blue", "white" } )
            };

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        
        public IActionResult Index()
        {
            return View(countries);
        }

        [HttpPost]
        public IActionResult Index(Country CountrySelect)
        {
            TempData["Name"] = CountrySelect;

            return View("Details", CountrySelect);
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Details()
        {
            return View("Details");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
