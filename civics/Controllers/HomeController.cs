using System.Web.Mvc;

namespace civics.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AnotherLink()
        {
            return View("Index");
        }

        public ActionResult Gallery()
        {
            return View("Gallery");
        }
    }
}
