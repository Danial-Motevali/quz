using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class HelloController1 : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            
            Session["Username"] = model.Username;

            HttpCookie cookie = new HttpCookie("Username", model.Username);
            Response.Cookies.Add(cookie);

            return RedirectToAction("Index", "Home");
        }
        public IActionResult Index()
        {

            return View();
        }
    }
}
