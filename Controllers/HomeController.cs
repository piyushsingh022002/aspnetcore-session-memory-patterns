using Microsoft.AspNetCore.Mvc;

namespace SessionBasics.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //store a string in a session
            HttpContext.Session.SetString("UserName", "Piyush Singh");

            //retrive username here
            var name = HttpContext.Session.GetString("UserName");
            ViewBag.Name = name;
            return View();

        }

        public IActionResult ClearSession()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}