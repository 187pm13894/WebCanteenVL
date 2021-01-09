using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCanteenVL.Models;

namespace WebCanteenVL.Areas.Admin.Controllers
{
    public class AuthController : Controller
    {
        AD2Team1Entities model = new AD2Team1Entities();
        // GET: Admin/Auth
        public ActionResult Login()
        {
            Session["user-not-found"] = false;
            Session["password-incorrect"] = false;
            return View();
        }

        [HttpPost]
        public ActionResult Login(String email, String password)
        {
            var user = model.ACCOUNTs.FirstOrDefault(u => u.EMAIL.Equals(email));
            if(user != null)
            {
                if (user.PASSWORD.Equals(password))
                {
                    Session["user-fullname"] = user.FULL_NAME;
                    Session["user-id"] = user.ID;
                    Session["user-role"] = user.ROLE;
                    return RedirectToAction("Index", "CategoryAdmin");
                }
                else
                {
                    Session["password-incorrect"] = true;
                    return View();
                }
            }
            Session["user-not-found"] = true;
            return View();
        }

        public ActionResult Logout()
        {
            Session["user-fullname"] = null;
            Session["user-id"] = null;
            return RedirectToAction("Login");
        }
    }
}