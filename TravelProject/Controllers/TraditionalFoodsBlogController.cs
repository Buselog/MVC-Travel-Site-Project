using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Classes;

namespace TravelProject.Controllers
{
    public class TraditionalFoodsBlogController : Controller
    {
        Context db = new Context();
        public ActionResult TraditionalFoodsBlogIndex()
        {
            var values = db.Tbl_TraditionalFoodsBlog.ToList();
            return View(values);
        }
    }
}