using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MountainTrailsWebApp.Models;

namespace MountainTrailsWebApp.Controllers
{
	public class NoPeopleArrMR20ModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: NoPeopleArrMR20Models
        public ActionResult Index()
        {
            return View(db.NoPeopleArrMR20.ToList());
        }

        // GET: NoPeopleArrMR20Models/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NoPeopleArrMR20Models noPeopleArrMR20Models = db.NoPeopleArrMR20.Find(id);
            if (noPeopleArrMR20Models == null)
            {
                return HttpNotFound();
            }
            return View(noPeopleArrMR20Models);
        }

        // GET: NoPeopleArrMR20Models/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NoPeopleArrMR20Models/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ArrivalId,Hotels,Hostels,Motels,Villas,Cabins,Campings,Stops,Pensions,Village")] NoPeopleArrMR20Models noPeopleArrMR20Models)
        {
            if (ModelState.IsValid)
            {
                db.NoPeopleArrMR20.Add(noPeopleArrMR20Models);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(noPeopleArrMR20Models);
        }

        // GET: NoPeopleArrMR20Models/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NoPeopleArrMR20Models noPeopleArrMR20Models = db.NoPeopleArrMR20.Find(id);
            if (noPeopleArrMR20Models == null)
            {
                return HttpNotFound();
            }
            return View(noPeopleArrMR20Models);
        }

        // POST: NoPeopleArrMR20Models/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ArrivalId,Hotels,Hostels,Motels,Villas,Cabins,Campings,Stops,Pensions,Village")] NoPeopleArrMR20Models noPeopleArrMR20Models)
        {
            if (ModelState.IsValid)
            {
                db.Entry(noPeopleArrMR20Models).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(noPeopleArrMR20Models);
        }

        // GET: NoPeopleArrMR20Models/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NoPeopleArrMR20Models noPeopleArrMR20Models = db.NoPeopleArrMR20.Find(id);
            if (noPeopleArrMR20Models == null)
            {
                return HttpNotFound();
            }
            return View(noPeopleArrMR20Models);
        }

        // POST: NoPeopleArrMR20Models/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NoPeopleArrMR20Models noPeopleArrMR20Models = db.NoPeopleArrMR20.Find(id);
            db.NoPeopleArrMR20.Remove(noPeopleArrMR20Models);
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
