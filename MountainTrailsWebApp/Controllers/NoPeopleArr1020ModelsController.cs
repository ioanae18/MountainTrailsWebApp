using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MountainTrailsWebApp.Models;

namespace MountainTrailsWebApp.Controllers
{
	public class NoPeopleArr1020ModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: NoPeopleArr1020Models
        public ActionResult Index()
        {
            return View(db.NoPeopleArr1020.ToList());
        }

        // GET: NoPeopleArr1020Models/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NoPeopleArr1020Models noPeopleArr1020Models = db.NoPeopleArr1020.Find(id);
            if (noPeopleArr1020Models == null)
            {
                return HttpNotFound();
            }
            return View(noPeopleArr1020Models);
        }

        // GET: NoPeopleArr1020Models/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NoPeopleArr1020Models/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ArrivalId,Hotels,Hostels,Motels,Hans,Villas,Cabins,Campings,Stops,Pensions,Year")] NoPeopleArr1020Models noPeopleArr1020Models)
        {
            if (ModelState.IsValid)
            {
                db.NoPeopleArr1020.Add(noPeopleArr1020Models);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(noPeopleArr1020Models);
        }

        // GET: NoPeopleArr1020Models/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NoPeopleArr1020Models noPeopleArr1020Models = db.NoPeopleArr1020.Find(id);
            if (noPeopleArr1020Models == null)
            {
                return HttpNotFound();
            }
            return View(noPeopleArr1020Models);
        }

        // POST: NoPeopleArr1020Models/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ArrivalId,Hotels,Hostels,Motels,Hans,Villas,Cabins,Campings,Stops,Pensions,Year")] NoPeopleArr1020Models noPeopleArr1020Models)
        {
            if (ModelState.IsValid)
            {
                db.Entry(noPeopleArr1020Models).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(noPeopleArr1020Models);
        }

        // GET: NoPeopleArr1020Models/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NoPeopleArr1020Models noPeopleArr1020Models = db.NoPeopleArr1020.Find(id);
            if (noPeopleArr1020Models == null)
            {
                return HttpNotFound();
            }
            return View(noPeopleArr1020Models);
        }

        // POST: NoPeopleArr1020Models/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NoPeopleArr1020Models noPeopleArr1020Models = db.NoPeopleArr1020.Find(id);
            db.NoPeopleArr1020.Remove(noPeopleArr1020Models);
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
