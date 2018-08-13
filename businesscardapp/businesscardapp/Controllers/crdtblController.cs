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
    public class CrdtblController : Controller
    {
        private bcEntities db = new bcEntities();

        // GET: crdtbl
        public ActionResult Index()
        {
            var cardtbls = db.cardtbls.Include(c => c.usertbl);
            return View(cardtbls.ToList());
        }

        // GET: crdtbl/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cardtbl cardtbl = db.cardtbls.Find(id);
            if (cardtbl == null)
            {
                return HttpNotFound();
            }
            return View(cardtbl);
        }

        // GET: crdtbl/Create
        public ActionResult Create()
        {
            ViewBag.userid = new SelectList(db.usertbls, "userid", "username");
            return View();
        }

        // POST: crdtbl/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cardid,userid,cardcontent")] cardtbl cardtbl)
        {
            if (ModelState.IsValid)
            {
                db.cardtbls.Add(cardtbl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.userid = new SelectList(db.usertbls, "userid", "username", cardtbl.userid);
            return View(cardtbl);
        }

        // GET: crdtbl/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cardtbl cardtbl = db.cardtbls.Find(id);
            if (cardtbl == null)
            {
                return HttpNotFound();
            }
            ViewBag.userid = new SelectList(db.usertbls, "userid", "username", cardtbl.userid);
            return View(cardtbl);
        }

        // POST: crdtbl/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cardid,userid,cardcontent")] cardtbl cardtbl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cardtbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.userid = new SelectList(db.usertbls, "userid", "username", cardtbl.userid);
            return View(cardtbl);
        }

        // GET: crdtbl/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cardtbl cardtbl = db.cardtbls.Find(id);
            if (cardtbl == null)
            {
                return HttpNotFound();
            }
            return View(cardtbl);
        }

        // POST: crdtbl/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            cardtbl cardtbl = db.cardtbls.Find(id);
            db.cardtbls.Remove(cardtbl);
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
