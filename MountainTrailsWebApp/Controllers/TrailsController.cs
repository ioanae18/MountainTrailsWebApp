//using MountainTrailsWebApp.Models;
//using System.Collections.Generic;
//using System.Web.Mvc;

//namespace MountainTrailsWebApp.Controllers
//{
//	public class TrailsController : Controller
//    {
//        public static List<Trail> trails = new List<Trail>();
//        public static int Id = 0;

//        // GET: Trails
//        public ActionResult TrailIndex()
//        {
//            //Trail trail = new Trail()
//            //{
//            //    Id = 1,
//            //    trailName = "Sinaia",
//            //    dificulty = Models.Trail.Dificulty.Medium,
//            //    duration = 1,
//            //    kilometers = 1,
//            //    climb = 1,
//            //    descend = 1,
//            //    seasonality = 1
//            //};

//            return View(trails);
//        }

//        [HttpGet]
//        public ActionResult TrailDetails(int id)
//        {
//            Trail trail = trails.Find(u => u.Id == id);
//            if (trail == null)
//            {
//                return HttpNotFound();
//            }
//            return View(trail);
//        }

//        [HttpGet]
//        public ActionResult CreateTrail()
//		{
//            return View();
//        }

//        [HttpPost]
//        public ActionResult CreateTrail(Trail trail)
//        {
//            Id++;
//            trail.Id = Id;
//            trails.Add(trail);
//            return RedirectToAction("TrailIndex");

//            //returnam view-ul de Trail cu obiectul de tocmai l-a primit de la user
//            //return View("Trail", trail);
//        }

//        [HttpGet]
//        public ActionResult DeleteTrail(int id)
//        {
//            Trail trail = trails.Find(u => u.Id == id);
//            if (trail == null)
//            {
//                return HttpNotFound();
//            }

//            trails.Remove(trail);

//            return RedirectToAction("TrailIndex");
//        }

//        [HttpGet]
//        public ActionResult EditTrail(int id)
//        {
//            Trail trail = trails.Find(u => u.Id == id);
//            if (trail == null)
//            {
//                return HttpNotFound();
//            }
//            return View(trail);
//        }

//        [HttpPost]
//        public ActionResult Edit(Trail trail)
//        {
//            //Modalitatea 1
//            Trail trailFromList = trails.Find(u => u.Id == trail.Id);
//            trailFromList.trailName   = trail.trailName;
//            trailFromList.dificulty   = trail.dificulty;
//            trailFromList.duration    = trail.duration;
//            trailFromList.kilometers  = trail.kilometers;
//            trailFromList.climb       = trail.climb;
//            trailFromList.descend     = trail.descend;
//            trailFromList.seasonality = trail.seasonality;


//            //Modalitatea 2
//            //Trail trailFromList2 = trails.Find(u => u.Id == trail.Id);
//            //trails.Remove(trailFromList2);
//            //trails.Remove(trail);

//            return RedirectToAction("TrailIndex");
//        }
//    }
//}