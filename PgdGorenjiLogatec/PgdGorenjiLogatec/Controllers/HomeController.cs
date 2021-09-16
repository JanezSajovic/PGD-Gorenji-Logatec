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

        public IActionResult ArhivAjax(int leto) {
            int a = 1;
            string rez = "";
            List<Intervencija> AllArhiv = GetIntervencije(2021);
            AllArhiv.Reverse();
            foreach (var inter in AllArhiv) { 
                rez += "<article class='entry' data-aos='fade - up'><h4 class='entry-title'>"+inter.Naslov.ToUpper()+"</h4><div class='entry-meta'><ul>" +
                    "<li class='d-flex align-items-center'><i class='icofont-wall-clock'></i> " +
                    "<a href = 'blog-single.html'><time datetime='"+inter.Datum+"'>"+inter.Datum.ToShortDateString()+"</time></a></li></ul></div><div class='entry-content'><p> "+inter.Opis+"</p></div></article>"; 
            }
            return Content(rez);
        }

        public List<Intervencija> GetIntervencije(int leto = 2021)
        {
            string json = "";
            List<Intervencija> intervencije = new List<Intervencija>();
            using (StreamReader r = new StreamReader("Data/Baza_Intervencije_"+leto+".json"))
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
