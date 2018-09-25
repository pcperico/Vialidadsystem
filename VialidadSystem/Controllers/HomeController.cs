using System.Web.Mvc;
using Vialidad.Common.Models;

namespace VialidadSystem.Controllers
{
    public class HomeController : Controller
    {        
        public ActionResult Index()
        {
            var model = new LoginModel();
            return View(model);
        }

        public ActionResult Login(LoginModel model)
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}