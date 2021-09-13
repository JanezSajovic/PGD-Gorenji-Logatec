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
            return View();
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
            All_Intervencije All = GetIntervencije();
            //Intervencija ewq = new Intervencija();
            //ewq.Id = 4;
            //ewq.Datum = "1.1.1111";
            //ewq.Naslov = "qweqwe";
            //ewq.Opis = "qweqwe";
            //All.SeznamIntervencij.Add(ewq);
            return View(All);
        }

        public All_Intervencije GetIntervencije()
        {
            string json = "";
            All_Intervencije intervencije = new All_Intervencije();
            List<Intervencija> qwe = new List<Intervencija>();
            using (StreamReader r = new StreamReader("Data/Baza_Intervencije_2021.json"))
            {
                json = r.ReadToEnd();
                //intervencije = JsonConvert.DeserializeObject<All_Intervencije>(json);
                qwe = JsonConvert.DeserializeObject<List<Intervencija>>(json);
            }
            int a = 1;

            return intervencije;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
