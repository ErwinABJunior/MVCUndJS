using OddToFood.Models;
using System.Web.Mvc;


namespace OddToFood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var model = new AboutModel();
            model.Name = "Something";
            model.Location = "Some Location";
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}