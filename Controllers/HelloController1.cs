using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class HelloController1 : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Index model)
        {
            Session["Name"] = model.Name; ;

            var cookie = new HttpCookie("MyCookie", "CookieValue");
            cookie.Expires = DateTime.Now;
            Response.Cookies.Add(cookie);

            return RedirectToAction("Index", "Home");
        }
    }
}
