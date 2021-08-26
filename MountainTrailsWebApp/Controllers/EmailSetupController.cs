using System.Net.Mail;
using System.Web.Mvc;
using System.Net;

namespace MountainTrailsWebApp.Controllers
{
	public class EmailSetupController : Controller
    {
        // GET: EmailSetup
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(MountainTrailsWebApp.Models.Gmail model)
        {
            MailMessage mm = new MailMessage("ioanae181@gmail.com", model.To);
            mm.Subject = model.Subject;
            mm.Body = mm.Body;
            mm.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            NetworkCredential nc = new NetworkCredential("example@gmail.com", "example");
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = nc;
            smtp.Send(mm);
            ViewBag.Message = "Mail has been sent succesfully!";

            return View();
        }
    }
}