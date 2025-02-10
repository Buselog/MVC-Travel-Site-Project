using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Classes;

namespace TravelProject.Controllers
{
    public class HotelsBlogController : Controller
    {
        Context db = new Context();
        public ActionResult HotelsBlogIndex()
        {
            var values = db.Tbl_HotelsBlog.ToList();
            return View(values);
        }
    }
}