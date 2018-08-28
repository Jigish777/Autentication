using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }
        public ActionResult Index()
        {
            return View();
        }

        [CustomAuthorizeAttribute]
        public ActionResult Profile()
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

        [ValidateAntiForgeryToken]
        [HttpPost]
        public RedirectResult Login(string UserName,string Password)
        {
            if (UserName == "Jigish" && Password == "Desai")
            {
                FormsAuthentication.SetAuthCookie(UserName, true);
                return Redirect("/Home/Profile");
            }
            return Redirect("/Home/Index");
        }


    }
}