using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelProject.Models.Classes;

namespace TravelProject.Controllers
{
   
    public class LoginLayoutController : Controller
    {
        Context db = new Context();

        [HttpGet]
        public ActionResult LoginIndex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginIndex(Admin admin)
        {
            var userInfo = db.Tbl_Admin.FirstOrDefault(x => x.AdminUser == admin.AdminUser && x.Password == admin.Password);
            if (userInfo != null)
            {
                FormsAuthentication.SetAuthCookie(userInfo.AdminUser, false);
                Session["Admin"] = userInfo.AdminUser.ToString();
                return RedirectToAction("BlogIndex", "AdminBlog");
            }
            else
            {
                return View();
            }
            
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LoginIndex", "LoginLayout");
        }
    }
}