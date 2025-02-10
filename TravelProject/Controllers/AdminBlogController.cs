using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Classes;

namespace TravelProject.Controllers
{
    public class AdminBlogController : Controller
    {
        Context db = new Context();

        [Authorize]
        public ActionResult BlogIndex()
        {
            var values = db.Tbl_Blog.ToList();
            return View(values);
        }


        [HttpGet]
        public ActionResult CreateNewBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateNewBlog(Blog blog)
        {
            db.Tbl_Blog.Add(blog);
            db.SaveChanges();
            return RedirectToAction("BlogIndex");
        }

        public ActionResult DeleteBlog(int id)
        {
            var values = db.Tbl_Blog.Find(id);
            db.Tbl_Blog.Remove(values);
            db.SaveChanges();
            return RedirectToAction("BlogIndex");
        }

        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            var values = db.Tbl_Blog.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateBlog(Blog tbl)
        {
            var values = db.Tbl_Blog.Find(tbl.BlogID);
            values.BlogTitle = tbl.BlogTitle;
            values.BlogDescription = tbl.BlogDescription;
            values.BlogDate = tbl.BlogDate;
            values.BlogImageUrl = tbl.BlogImageUrl;
            db.SaveChanges();
            return RedirectToAction("BlogIndex");
        }
    }
}