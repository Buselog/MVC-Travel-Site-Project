using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Classes;


namespace TravelProject.Controllers
{
    public class AboutController : Controller
    {
        Context db = new Context();
        
        public ActionResult AboutIndex()
        {
            var values = db.Tbl_About.ToList();
            return View(values);
        }
    }
}