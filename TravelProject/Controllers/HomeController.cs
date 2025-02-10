using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Classes;

namespace TravelProject.Controllers
{
    public class HomeController : Controller
    {
        Context db = new Context();
        public ActionResult HomeIndex()
        {
            var imagesFromBlog = db.Tbl_Blog.ToList();
            return View(imagesFromBlog);
        }

        public PartialViewResult BannerLeftPartial()
        {
            return PartialView();
        }

        public PartialViewResult ConBotPartial()
        {
            var values = db.Tbl_Blog.OrderByDescending(x => x.BlogID).Take(3).ToList();
            return PartialView(values);
        }

        public PartialViewResult Top5Partial()
        {
            var values = db.Tbl_Blog.OrderByDescending(x => x.BlogID).Take(5).ToList();
            return PartialView(values);
        }

        public PartialViewResult BestPlacesPartial()
        {
            var values = db.Tbl_Blog.OrderByDescending(x => x.BlogID).Take(3).ToList();
            return PartialView(values);
        }

        public PartialViewResult BestPlacesPartialRight()
        {
            var values = db.Tbl_Blog.Take(3).ToList();
            return PartialView(values);
        }

    }
}