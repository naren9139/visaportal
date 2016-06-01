using System.Web.Mvc;

namespace VisaPortal.Controllers
{
    public class VisaController : Controller
    {
        public ActionResult VisaHome()
        {
           return View();
        }

        [HttpPost]
        public ActionResult VisaHome(string comment)
        {
            return View();
        }


    }
}