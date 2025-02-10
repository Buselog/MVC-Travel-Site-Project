using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Classes;

namespace TravelProject.Controllers
{
    public class AdminContactController : Controller
    {
        Context db = new Context();

        [Authorize]
        public ActionResult ContactIndex()
        {
            var values = db.Tbl_Contact.ToList();
            return View(values);
        }

        public ActionResult DeleteContact(int id)
        {
            var values = db.Tbl_Contact.Find(id);
            db.Tbl_Contact.Remove(values);
            db.SaveChanges();
            return RedirectToAction("ContactIndex");
        }
    }
}