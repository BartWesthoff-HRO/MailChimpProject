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
                Employee userDetails = db.Empobj.Where(x => x.username == employee.username && x.password == employee.password).FirstOrDefault();
                if (userDetails == null)
                {
                    employee.loginerrormessage = "Wrong username or password.";
                    return View("Index", employee);
                }
                else
                {
                    Session["userid"] = userDetails.userid;
                    Session["username"] = userDetails.username;
                    return RedirectToAction("Index", "Emp");
                }
            }
     
        }
    }
}