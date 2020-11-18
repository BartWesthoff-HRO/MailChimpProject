using MailChimp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MailChimp.Controllers
{
    public class ContactPersonController : Controller
    {
        // GET: ContactPerson
        public ActionResult Index()
        {

            List<ContactPersoon> personenLijst = new List<ContactPersoon>();

            personenLijst.Add(new ContactPersoon() { voornaam = "Bart", achternaam = "Westhoff", email = "bartwesthoff@mail.com", bedrijfsnaam = "Bart.BV", tussenvoegsel = ""});
            personenLijst.Add(new ContactPersoon() { voornaam = "Tijmen", achternaam = "Rietveld", email = "rietveld@mail.com", bedrijfsnaam = "Bart.BV", tussenvoegsel = "" });
            personenLijst.Add(new ContactPersoon() { voornaam = "Nathan", achternaam = "Samjio", email = "samjio@mail.com", bedrijfsnaam = "Bart.BV", tussenvoegsel = "" });
            personenLijst.Add(new ContactPersoon() { voornaam = "Isabelle", achternaam = "Stienen", email = "stienen@mail.com", bedrijfsnaam = "Bart.BV", tussenvoegsel = "" });
            return View(personenLijst);
        }
    }
}