using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Classes;

namespace TravelProject.Controllers
{
    public class AdminAboutController : Controller
    {
        Context db = new Context();

        [Authorize]
        public ActionResult AboutIndex()
        {
            var values = db.Tbl_About.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var values = db.Tbl_About.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateAbout(About tbl)
        {
            var values = db.Tbl_About.Find(tbl.AboutID);
            values.AboutImageUrl = tbl.AboutImageUrl;
            values.AboutDescription = tbl.AboutDescription;
            db.SaveChanges();
            return RedirectToAction("AboutIndex");
        }

        public ActionResult DeleteAbout(int id)
        {
            var values = db.Tbl_About.Find(id);
            db.Tbl_About.Remove(values);
            return RedirectToAction("AboutIndex");
           
        }
    }
}