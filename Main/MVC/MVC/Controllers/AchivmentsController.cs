using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class AchivmentsController : Controller
    {
        private GameDBContext db = new GameDBContext();

        // GET: Achivments
        public ActionResult Index()
        {
            var achivments = db.Achivments.Include(a => a.Game);
            return View(achivments.ToList());
        }

        // GET: Achivments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Achivment achivment = db.Achivments.Find(id);
            if (achivment == null)
            {
                return HttpNotFound();
            }
            return View(achivment);
        }

        // GET: Achivments/Create
        public ActionResult Create()
        {
            ViewBag.GameID = new SelectList(db.Games, "ID", "Title");
            return View();
        }

        // POST: Achivments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AchivmentID,GameID,AchivmentTitle,AchivmentDescription")] Achivment achivment)
        {
            if (ModelState.IsValid)
            {
                db.Achivments.Add(achivment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GameID = new SelectList(db.Games, "ID", "Title", achivment.GameID);
            return View(achivment);
        }

        // GET: Achivments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Achivment achivment = db.Achivments.Find(id);
            if (achivment == null)
            {
                return HttpNotFound();
            }
            ViewBag.GameID = new SelectList(db.Games, "ID", "Title", achivment.GameID);
            return View(achivment);
        }

        // POST: Achivments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AchivmentID,GameID,AchivmentTitle,AchivmentDescription")] Achivment achivment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(achivment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GameID = new SelectList(db.Games, "ID", "Title", achivment.GameID);
            return View(achivment);
        }

        // GET: Achivments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Achivment achivment = db.Achivments.Find(id);
            if (achivment == null)
            {
                return HttpNotFound();
            }
            return View(achivment);
        }

        // POST: Achivments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Achivment achivment = db.Achivments.Find(id);
            db.Achivments.Remove(achivment);
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
