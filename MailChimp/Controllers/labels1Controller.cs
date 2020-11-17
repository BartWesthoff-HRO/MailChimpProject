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
    public class labels1Controller : Controller
    {
        private ApplicationDBContext db = new ApplicationDBContext();

        // GET: labels1
        public ActionResult Index()
        {
            return View(db.labels.ToList());
        }

        // GET: labels1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            labels labels = db.labels.Find(id);
            if (labels == null)
            {
                return HttpNotFound();
            }
            return View(labels);
        }

        // GET: labels1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: labels1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "labelid,lname")] labels labels)
        {
            if (ModelState.IsValid)
            {
                db.labels.Add(labels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(labels);
        }

        // GET: labels1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            labels labels = db.labels.Find(id);
            if (labels == null)
            {
                return HttpNotFound();
            }
            return View(labels);
        }

        // POST: labels1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "labelid,lname")] labels labels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(labels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(labels);
        }

        // GET: labels1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            labels labels = db.labels.Find(id);
            if (labels == null)
            {
                return HttpNotFound();
            }
            return View(labels);
        }

        // POST: labels1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            labels labels = db.labels.Find(id);
            db.labels.Remove(labels);
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
