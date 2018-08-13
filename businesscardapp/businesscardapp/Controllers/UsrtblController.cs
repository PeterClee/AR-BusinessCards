using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using businesscardapp.Models;

namespace businesscardapp.Views
{
    public class UsrtblController : Controller
    {
        private businesscardsEntities db = new businesscardsEntities();

        // GET: usrtbl
        public ActionResult Index()
        {
            return View(db.usertbls.ToList());
        }

        // GET: usrtbl/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            usertbl usertbl = db.usertbls.Find(id);
            if (usertbl == null)
            {
                return HttpNotFound();
            }
            return View(usertbl);
        }

        // GET: usrtbl/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: usrtbl/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "userid,username,email")] usertbl usertbl)
        {
            if (ModelState.IsValid)
            {
                db.usertbls.Add(usertbl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usertbl);
        }

        // GET: usrtbl/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            usertbl usertbl = db.usertbls.Find(id);
            if (usertbl == null)
            {
                return HttpNotFound();
            }
            return View(usertbl);
        }

        // POST: usrtbl/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "userid,username,email")] usertbl usertbl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usertbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usertbl);
        }

        // GET: usrtbl/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            usertbl usertbl = db.usertbls.Find(id);
            if (usertbl == null)
            {
                return HttpNotFound();
            }
            return View(usertbl);
        }

        // POST: usrtbl/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            usertbl usertbl = db.usertbls.Find(id);
            db.usertbls.Remove(usertbl);
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
