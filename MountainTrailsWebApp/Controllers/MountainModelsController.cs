using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MountainTrailsWebApp.Models;

namespace MountainTrailsWebApp.Controllers
{
    public class MountainModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MountainModels
        public ActionResult Index()
        {
            return View(db.Mountains.ToList());
        }

        // GET: MountainModels/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MountainModels mountainModels = db.Mountains.Find(id);
            if (mountainModels == null)
            {
                return HttpNotFound();
            }
            return View(mountainModels);
        }

        // GET: MountainModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MountainModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdMountain,MountainName,IdCounty,IdTrail,IdPeak")] MountainModels mountainModels)
        {
            if (ModelState.IsValid)
            {
                db.Mountains.Add(mountainModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mountainModels);
        }

        // GET: MountainModels/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MountainModels mountainModels = db.Mountains.Find(id);
            if (mountainModels == null)
            {
                return HttpNotFound();
            }
            return View(mountainModels);
        }

        // POST: MountainModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdMountain,MountainName,IdCounty,IdTrail,IdPeak")] MountainModels mountainModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mountainModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mountainModels);
        }

        // GET: MountainModels/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MountainModels mountainModels = db.Mountains.Find(id);
            if (mountainModels == null)
            {
                return HttpNotFound();
            }
            return View(mountainModels);
        }

        // POST: MountainModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            MountainModels mountainModels = db.Mountains.Find(id);
            db.Mountains.Remove(mountainModels);
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
