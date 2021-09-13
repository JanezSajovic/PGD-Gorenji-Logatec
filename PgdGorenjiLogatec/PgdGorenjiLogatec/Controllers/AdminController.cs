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
            string json = "";
            All_Intervencije intervencije = new All_Intervencije();
            using (StreamReader r = new StreamReader("Data/Baza_Intervencije.json"))
            {
                json = r.ReadToEnd();
                intervencije = JsonConvert.DeserializeObject<All_Intervencije>(json);
            }

            return View(intervencije);
            //return View();
        }

        public ActionResult Uredi(int id) {
            string json = "";
            Intervencija glavna_intervencija = new Intervencija();
            All_Intervencije intervencije = new All_Intervencije();
            using (StreamReader r = new StreamReader("Data/Baza_Intervencije_2021.json"))
            {
                json = r.ReadToEnd();
                intervencije = JsonConvert.DeserializeObject<All_Intervencije>(json);
            }
            foreach (var inter in intervencije.SeznamIntervencij) {
                if (inter.Id == id) {
                    return View(inter);
                }
            }

            return View(glavna_intervencija);
        }

        [HttpPost]
        public ActionResult Uredi(Intervencija i)
        {
            string json = "";
            Intervencija glavna_intervencija = new Intervencija();
            All_Intervencije intervencije = new All_Intervencije();
            using (StreamReader r = new StreamReader("Data/Baza_Intervencije.json"))
            {
                json = r.ReadToEnd();
                intervencije = JsonConvert.DeserializeObject<All_Intervencije>(json);
            }
            foreach (var inter in intervencije.SeznamIntervencij)
            {
                if (inter.Id == i.Id)
                {
                    inter.Naslov = i.Naslov;
                    inter.Datum = i.Datum;
                    inter.Opis = i.Opis;
                    break;
                }
            }

            Write(intervencije);

            return View(i);
        }

        public void Write(All_Intervencije model)
        {
            string json = JsonConvert.SerializeObject(model.SeznamIntervencij.ToArray());

            //write string to file
            System.IO.File.WriteAllText("Data\\Baza_Intervencije_2021.json", json);
        }



    }
}
