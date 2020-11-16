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

            List<ContactPerson> personenLijst = new List<ContactPerson>();

            personenLijst.Add(new ContactPerson() { FirstName="Bart", LastName = "Westhoff", Company = "groepje 6", Label = "werknemer", email = "bartW@email.com" });
            personenLijst.Add(new ContactPerson() { FirstName = "Tijmen", LastName = "Rietveld", Company = "groepje 6", Label = "werknemer", email = "TijmenR@email.com" });
            personenLijst.Add(new ContactPerson() { FirstName = "Nathan", LastName = "Samjio", Company = "groepje 6", Label = "werknemer", email = "NathanS@email.com" });
            personenLijst.Add(new ContactPerson() { FirstName = "Isabelle", LastName = "Stienen", Company = "groepje 6", Label = "Scrummaster", email = "IsabelleS@email.com" });
            return View(personenLijst);
        }
    }
}