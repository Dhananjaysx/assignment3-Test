using Microsoft.AspNetCore.Mvc;

namespace MVC_Design.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult Company()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}