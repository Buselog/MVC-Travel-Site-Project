using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Classes;

namespace TravelProject.Controllers
{
    public class BlogController : Controller
    {
        Context db = new Context();

        //Sınıftan nesne türetimi ile erişim sağlanacak:
        BlogComments bc = new BlogComments();

        public ActionResult BlogIndex()
        {
            //var values = db.Tbl_Blog.ToList();
            bc.Value1 = db.Tbl_Blog.Take(10).ToList();
            bc.Value3 = db.Tbl_Blog.OrderByDescending(x => x.BlogID).Take(3); 
            //Recent Blogs başlığı için Id'ye göre Blogları sondan başa listeleyip ilk üçü al.
            return View(bc);
        }

        [HttpGet]
        public PartialViewResult CommentPartial(int id)
        {
            ViewBag.commentBlogId = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult CommentPartial(Comments newComment)
        {
            db.Tbl_Comment.Add(newComment);
            db.SaveChanges();
            //return PartialView();
            return PartialView();
        }


        public ActionResult BlogDetail(int id)
        {
            //var values = db.Tbl_Blog.Where(x=>x.BlogID==id).ToList();
            //BlogDetail sayfasına birden fazla tablodan veri çekeceğimiz için 
            //BlogComments sınıfındaki verilere atamalar yaptık ve View kısmına kullanılmak üzere
            // sınıfın nesnesini gönderdik
            bc.Value1 = db.Tbl_Blog.Where(x => x.BlogID == id).ToList();
            bc.Value2 = db.Tbl_Comment.Where(x => x.BlogId == id).ToList();
            bc.Value3 = db.Tbl_Blog.OrderByDescending(x => x.BlogID).Take(3); //For Recent Blogs Partial
            return View(bc);
        }

    }
}