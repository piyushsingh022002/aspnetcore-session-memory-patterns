using Microsoft.AspNetCore.Mvc;

namespace SessionBasics.Controllers
{
    public class SimpleSessionController : Controller
    {
        public IActionResult Index()
        {
            //store a string in a session
            HttpContext.Session.SetString("UserName", "SimpleSessionController.Piyush Singh");

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