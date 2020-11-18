using MailChimp.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MailChimp.Models;

namespace MailChimp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Autherize(Employee employee)
        {
            using (ApplicationDBContext db = new ApplicationDBContext())
            {
                Employee userDetails = db.Empobj.Where(x => x.gebruikersnaam == employee.gebruikersnaam && x.wachtwoord == employee.wachtwoord).FirstOrDefault();
                if (userDetails == null)
                {
                    
                    return View("Index", employee);
                }
                else
                {
                    Session["userid"] = userDetails.medewerkerid;
                    Session["username"] = userDetails.gebruikersnaam;
                    return RedirectToAction("Index", "Home");
                }
            }
     
        }
    }
}