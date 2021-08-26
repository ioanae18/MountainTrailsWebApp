using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MountainTrailsWebApp.Models;

namespace MountainTrailsWebApp.Controllers
{
	public class PeakModelsListController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PeakModelsList
        public ActionResult Index()
        {
            var peaks = db.Peaks.Include(p => p.Mountain);
            return View(peaks.ToList());
        }

        // GET: PeakModelsList/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PeakModels peakModels = db.Peaks.Find(id);
            if (peakModels == null)
            {
                return HttpNotFound();
            }
            return View(peakModels);
        }

        // GET: PeakModelsList/Create
        public ActionResult Create()
        {
            ViewBag.IdMountain = new SelectList(db.Mountains, "IdMountain", "MountainName");
            return View();
        }

        // POST: PeakModelsList/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPeak,PeakName,Height,IdMountain")] PeakModels peakModels)
        {
            if (ModelState.IsValid)
            {
                db.Peaks.Add(peakModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdMountain = new SelectList(db.Mountains, "IdMountain", "MountainName", peakModels.IdMountain);
            return View(peakModels);
        }

        // GET: PeakModelsList/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PeakModels peakModels = db.Peaks.Find(id);
            if (peakModels == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdMountain = new SelectList(db.Mountains, "IdMountain", "MountainName", peakModels.IdMountain);
            return View(peakModels);
        }

        // POST: PeakModelsList/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPeak,PeakName,Height,IdMountain")] PeakModels peakModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(peakModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdMountain = new SelectList(db.Mountains, "IdMountain", "MountainName", peakModels.IdMountain);
            return View(peakModels);
        }

        // GET: PeakModelsList/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PeakModels peakModels = db.Peaks.Find(id);
            if (peakModels == null)
            {
                return HttpNotFound();
            }
            return View(peakModels);
        }

        // POST: PeakModelsList/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PeakModels peakModels = db.Peaks.Find(id);
            db.Peaks.Remove(peakModels);
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
