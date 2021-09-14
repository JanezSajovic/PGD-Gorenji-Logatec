using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PgdGorenjiLogatec.CustomModels;
using PgdGorenjiLogatec.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PgdGorenjiLogatec.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Domov()
        {
            List<Intervencija> All = GetIntervencije();
            List<Intervencija> temp = new List<Intervencija>();
            for (int i = All.Count()-1; i > All.Count - 4; i--) {
                temp.Add(All[i]);
            }
            return View(temp);
        }

        public IActionResult Kontakt()
        {
            return View();
        }
        public IActionResult Povezave()
        {
            return View();
        }

        public IActionResult Oprema()
        {
            return View();
        }

        public IActionResult Novice()
        {
            return View();
        }

        public IActionResult Intervencije()
        {
            List<Intervencija> All = GetIntervencije();
            All.Reverse();
            return View(All);
        }

        public List<Intervencija> GetIntervencije()
        {
            string json = "";
            List<Intervencija> intervencije = new List<Intervencija>();
            using (StreamReader r = new StreamReader("Data/Baza_Intervencije_2021.json"))
            {
                json = r.ReadToEnd();
                intervencije = JsonConvert.DeserializeObject<List<Intervencija>>(json);
                
            }
            return intervencije;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
