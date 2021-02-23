using CountriesAroundTheWorld.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;

namespace CountriesAroundTheWorld.Controllers
{
    public class HomeController : Controller
    {
        public List<Country> Countries { get; set; } = new List<Country>();

        public HomeController()
        {
            Country a = new Country("Algeria", new List<string>() { "Arabic", "Berber" }, "Salam", "Algeria is a country located in Northern Africa bordering the Mediterranean Sea. It is considered the gateway between Africa and Europe. Neighboring countries include Libya, Mali, Mauritania, Morocco, Niger, Tunisia, and Western Sahara. Algeria is mostly desert with a few mountains and a narrow coastal plain.", new List<string>() { "green", "white", "red" }, "/Images/Algeria.png");
            Countries.Add(a);
            Country b = new Country("Bahamas", new List<string>() { "English" }, "What da wybe is? ", "The Bahamas stretches for 760 miles from the coast of Florida in the northwest to almost Haiti in the southeast. The archipelago consists of about 2,400 Cays (coral reefs) and 700 islands, 30 of which are inhabited.", new List<string>() { "aquamarine", "yellow", "black" }, "/Images/Bahamas.webp");
            Countries.Add(b);
            Country c = new Country("Bangladesh", new List<string>() { "Bengali" }, "Assalam Waleykum' ('peace be with you')", "Bangladesh is a country in Southern Asia and is located on the Bay of Bengal bordered by India on all sides except for a small border with Burma. Bangladesh has flat plains, and most of the country is situated on deltas of large rivers flowing from the Himalayas.", new List<string>() { "red", "green", "gold" }, "/Images/bangladesh.jpg");
            Countries.Add(c);
            Country d = new Country("Venezuela", new List<string>() { "Spanish" }, "Buenos Días", "Venezuela is a federal presidential republic consisting of 23 states, the Capital District and federal dependencies covering Venezuela's offshore islands. Venezuela is among the most urbanized countries in Latin America; the vast majority of Venezuelans live in the cities of the north and in the capital.", new List<string>() { "yellow", "blue", "red" }, "/Images/venezuela.png");
            Countries.Add(d);
            Country e = new Country("Switzerland", new List<string>() { "German", "French", "Italian", "Romansh" }, "If you meet a friend, then you kiss them three times: offering first your right cheek, then left, then right again.", "Switzerland is a small mountainous country located in central Europe. This landlocked country is about the size of New Jersey and is between France and Italy. It is also bordered by Austria, Germany, and Liechtenstein.", new List<string>() { "white", "red" }, "/Images/swiss.png");
            Countries.Add(e);
        }

        public IActionResult Index()
        {
            return View(Countries);
        }
        [HttpPost]
        public IActionResult Index(string c)
        {
            foreach (Country country in Countries)
            {
                if (c == country.Name)
                {
                   TempData["name"]= country.Name;

                    string languageString= "";
                    foreach (string lang in country.Languages)
                    {
                        languageString += lang + ", ";
                        
                    }
                    TempData["language"] = languageString;
                    TempData["greeting"]=country.Greeting;
                    TempData["description"] = country.Description;
                    string colorString = "";
                    foreach (string color in country.Colors)
                    {
                        colorString += color + ", ";

                    }
                    TempData["colors"] = colorString;
                    TempData["flag"] = country.FlagSrc;
                    return RedirectToAction("Details", country);
                }
               
            }
            
            return View();

        }
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Description()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
