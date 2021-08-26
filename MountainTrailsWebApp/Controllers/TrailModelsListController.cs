using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MountainTrailsWebApp.Models;

namespace MountainTrailsWebApp.Controllers
{
	public class TrailModelsListController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TrailModelsList
        public ActionResult Index()
        {
            var trails = db.Trails.Include(t => t.Difficulty);
            return View(trails.ToList());
        }

        // GET: TrailModelsList/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrailModels trailModels = db.Trails.Find(id);
            if (trailModels == null)
            {
                return HttpNotFound();
            }
            return View(trailModels);
        }

        // GET: TrailModelsList/Create
        public ActionResult Create()
        {
            ViewBag.IdDifficulty = new SelectList(db.Difficulties, "IdDifficulty", "DifficultyName");
            return View();
        }

        // POST: TrailModelsList/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTrail,TrailName,Duration,Distance,Climb,Descend,IdSeason,IdDifficulty,IdMarkings,IdMountain")] TrailModels trailModels)
        {
            if (ModelState.IsValid)
            {
                db.Trails.Add(trailModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdDifficulty = new SelectList(db.Difficulties, "IdDifficulty", "DifficultyName", trailModels.IdDifficulty);
            return View(trailModels);
        }

        // GET: TrailModelsList/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrailModels trailModels = db.Trails.Find(id);
            if (trailModels == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdDifficulty = new SelectList(db.Difficulties, "IdDifficulty", "DifficultyName", trailModels.IdDifficulty);
            return View(trailModels);
        }

        // POST: TrailModelsList/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTrail,TrailName,Duration,Distance,Climb,Descend,IdSeason,IdDifficulty,IdMarkings,IdMountain")] TrailModels trailModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trailModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdDifficulty = new SelectList(db.Difficulties, "IdDifficulty", "DifficultyName", trailModels.IdDifficulty);
            return View(trailModels);
        }

        // GET: TrailModelsList/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrailModels trailModels = db.Trails.Find(id);
            if (trailModels == null)
            {
                return HttpNotFound();
            }
            return View(trailModels);
        }

        // POST: TrailModelsList/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TrailModels trailModels = db.Trails.Find(id);
            db.Trails.Remove(trailModels);
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
