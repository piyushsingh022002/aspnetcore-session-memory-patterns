using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using SessionBasics.Models;

namespace SessionBasics.Controllers
{
    public class ComplexSessionController : Controller
    {
        public IActionResult Index()
        {
            var user = new UserProfile
            {
                Id = 101,
                FullName = "Piyush Singh",
                Role = "Admin"
            };
            string json = JsonSerializer.Serialize(user);
            HttpContext.Session.SetString("UserProfile", json);

            string jsonFromSession = HttpContext.Session.GetString("UserProfile");
            var userFromSession = JsonSerializer.Deserialize<UserProfile>(jsonFromSession);

            return View(userFromSession);

        }

         public IActionResult Clear()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
        

    }
}