using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Classes;

namespace TravelProject.Controllers
{
    public class AdminHotelsBlogController : Controller
    {
        Context db = new Context();

        [Authorize]
        public ActionResult HotelsBlogIndex()
        {
            var values = db.Tbl_HotelsBlog.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddNewHotel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewHotel(HotelsBlog newHotel)
        {
            db.Tbl_HotelsBlog.Add(newHotel);
            db.SaveChanges();
            return RedirectToAction("HotelsBlogIndex");
        }

        [HttpGet]
        public ActionResult UpdateHotelsBlog(int id)
        {
            var values = db.Tbl_HotelsBlog.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateHotelsBlog(HotelsBlog hotels)
        {
            var values = db.Tbl_HotelsBlog.Find(hotels.HotelsBlogID);
            values.HotelName = hotels.HotelName;
            values.HotelLocation = hotels.HotelLocation;
            values.HotelRating = hotels.HotelRating;
            values.HotelShortDescription = hotels.HotelShortDescription;
            values.HotelImageUrl = hotels.HotelImageUrl;
            values.HotelContactLink = hotels.HotelContactLink;
            values.HotelSiteLink = hotels.HotelSiteLink;
            db.SaveChanges();
            return RedirectToAction("HotelsBlogIndex");
        }

        public ActionResult DeleteHotelsBlog(int id)
        {
            var values = db.Tbl_HotelsBlog.Find(id);
            db.Tbl_HotelsBlog.Remove(values);
            db.SaveChanges();
            return RedirectToAction("HotelsBlogIndex");
        }


    }
}