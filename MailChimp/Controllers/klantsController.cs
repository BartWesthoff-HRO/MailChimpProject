using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MailChimp.DataContext;
using MailChimp.Models;

namespace MailChimp.Controllers
{
    public class klantsController : Controller
    {
        private ApplicationDBContext db = new ApplicationDBContext();

        // GET: klants
        public ActionResult Index()
        {
            return View(db.klants.ToList());
        }

        // GET: klants/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            klant klant = db.klants.Find(id);
            if (klant == null)
            {
                return HttpNotFound();
            }
            return View(klant);
        }

        // GET: klants/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: klants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Firstname,Lastname,Bedrijfsnaam")] klant klant)
        {
            if (ModelState.IsValid)
            {
                db.klants.Add(klant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(klant);
        }

        // GET: klants/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            klant klant = db.klants.Find(id);
            if (klant == null)
            {
                return HttpNotFound();
            }
            return View(klant);
        }

        // POST: klants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Firstname,Lastname,Bedrijfsnaam")] klant klant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(klant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(klant);
        }

        // GET: klants/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            klant klant = db.klants.Find(id);
            if (klant == null)
            {
                return HttpNotFound();
            }
            return View(klant);
        }

        // POST: klants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            klant klant = db.klants.Find(id);
            db.klants.Remove(klant);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
