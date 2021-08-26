using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MountainTrailsWebApp.Models;

namespace MountainTrailsWebApp.Controllers
{
	public class MountainModelsListController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MountainModelsList
        public ActionResult Index()
        {
            return View(db.Mountains.ToList());
        }

        // GET: MountainModelsList/Details/5
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

        // GET: MountainModelsList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MountainModelsList/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdMountain,MountainName,Group,Division,IdCounty,IdTrail,IdPeak")] MountainModels mountainModels)
        {
            if (ModelState.IsValid)
            {
                db.Mountains.Add(mountainModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mountainModels);
        }

        // GET: MountainModelsList/Edit/5
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

        // POST: MountainModelsList/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdMountain,MountainName,Group,Division,IdCounty,IdTrail,IdPeak")] MountainModels mountainModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mountainModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mountainModels);
        }

        // GET: MountainModelsList/Delete/5
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

        // POST: MountainModelsList/Delete/5
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
