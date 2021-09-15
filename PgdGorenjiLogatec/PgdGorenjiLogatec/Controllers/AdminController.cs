using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Owin.Security;
using Newtonsoft.Json;
using PgdGorenjiLogatec.CustomModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PgdGorenjiLogatec.Controllers
{
    public class AdminController : Controller
    {
        // GET: AdminController
        [HttpGet]
        public ActionResult Prijava()
        {
            Uporabnik login = new Uporabnik();
            return View(login);
        }


        [HttpPost]
        public ActionResult Prijava(Uporabnik prijava)
        {
            if (ModelState.IsValid)
            {
                string json = "";
                All_Uporabniki VsiUporabniki = new All_Uporabniki();
                using (StreamReader r = new StreamReader("Data/Baza_Uporabniki.json"))
                {
                    json = r.ReadToEnd();
                    VsiUporabniki = JsonConvert.DeserializeObject<All_Uporabniki>(json);
                }

                foreach (var upo in VsiUporabniki.SeznamUporabnikov)
                {
                    if (prijava.UporabniskoIme == upo.UporabniskoIme && prijava.Geslo == upo.Geslo)
                    {
                        return RedirectToAction("Urejevalnik", "Admin");
                    }
                    else {
                        return RedirectToAction("Domov", "Home");
                    }
                }
            }
            return View();
        }

        public ActionResult Urejevalnik() {
            return View();
        }

        public ActionResult UrejanjeIntervencij()
        {
            List<Intervencija> All = GetIntervencije();
            return View(All);
        }

        public ActionResult Uredi(int id) {
            List<Intervencija> All = GetIntervencije();
            Intervencija glavna_intervencija = All.Find(x => x.Id == id);
            return View(glavna_intervencija);
        }

        [HttpPost]
        public ActionResult Uredi(Intervencija i)
        {
            List<Intervencija> All = GetIntervencije();
            Intervencija glavna_intervencija = new Intervencija();
            foreach (var inter in All)
            {
                if (inter.Id == i.Id)
                {
                    inter.Naslov = i.Naslov;
                    inter.Datum = i.Datum;
                    inter.Opis = i.Opis;
                    break;
                }
            }

            Write(All);

            return RedirectToAction("UrejanjeIntervencij", "Admin");
        }

        [HttpGet]
        public ActionResult Izbrisi(int id){
            List<Intervencija> All = GetIntervencije();
            Intervencija rez = All.Find(x => x.Id == id);
            return View(rez);
        }

        [HttpPost]
        public ActionResult Izbrisi(Intervencija i){
            List<Intervencija> All = GetIntervencije();
            All.RemoveAll(x => x.Id == i.Id);
            Write(All);
            return RedirectToAction("UrejanjeIntervencij", "Admin");
        }

        [HttpGet]
        public IActionResult Dodaj() {
            List<Intervencija> All = GetIntervencije();
            Intervencija temp = All.Last();
            Intervencija rez = new Intervencija();
            rez.Id = temp.Id + 1;
            return View(rez);
        }

        [HttpPost]
        public IActionResult Dodaj(Intervencija i)
        {
            List<Intervencija> All = GetIntervencije();
            All.Add(i);
            Write(All);
            return RedirectToAction("UrejanjeIntervencij", "Admin");
        }




        public void Write(List<Intervencija> model)
        {
            string json = JsonConvert.SerializeObject(model.ToArray());

            //write string to file
            System.IO.File.WriteAllText("Data\\Baza_Intervencije_2021.json", json);
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
    }
}
