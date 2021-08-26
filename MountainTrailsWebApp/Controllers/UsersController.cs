//using MountainTrailsWebApp.Models;
//using System.Collections.Generic;
//using System.Web.Mvc;

//namespace MountainTrailsWebApp.Controllers
//{
//	public class UsersController : Controller
//    {

//        public static List<User> users = new List<User>();
//        public static int Id = 1;

//        // GET: Users
        
//        public ActionResult User()   //la el este Index
//        {
//            //User user = new User
//            //{
//            //	Id = 1,
//            //	Age = 20,
//            //	FirstName = "aa",
//            //	LastName = "bb",
//            //	UserGender = Models.User.Gender.Female,
//            //	isEmployee = true
//            //};

//            //return View(user);

//            return View(users);
//        }

//        [HttpGet]
//        public ActionResult UserDetails(int id)  //la el este Details
//        {
//            User user = users.Find(u => u.Id == id);
//            if(user == null)
//			{
//                return HttpNotFound();
//			}
//            return View();
//        }

//        [HttpGet]
//        public ActionResult Create()  //la el este Create
//		{
//            return View();
//        }

//        [HttpPost]
//        public ActionResult Create(User user)
//        {
//            //returnam view-ul cu obiectul ce tocmai l-a primit de la user
//            //return View("User", user);

//            users.Add(user);
//            return RedirectToAction("User");
//        }

//        [HttpPost]
//        public ActionResult EditTrail(User user)
//        {
//            User trailFromList = users.Find(u => u.Id == user.Id);
//            return View(user);
//        }

//    }
//}