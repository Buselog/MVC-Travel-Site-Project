using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Classes;

namespace TravelProject.Controllers
{
    public class AdminAddressController : Controller
    {
        Context db = new Context();
        [Authorize]
        public ActionResult AddressIndex()
        {
            var values = db.Tbl_Address.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult UpdateAddress(int id)
        {
            var values = db.Tbl_Address.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateAddress(Address tbl)
        {
            var values = db.Tbl_Address.Find(tbl.AddressID);
            values.AddressPageTitle = tbl.AddressPageTitle;
            values.AddressPageDescription = tbl.AddressPageDescription;
            values.AddressFull = tbl.AddressFull;
            values.AddressMail = tbl.AddressMail;
            values.AddressPhone = tbl.AddressPhone;
            values.AddressLocation = tbl.AddressLocation;
            db.SaveChanges();
            return RedirectToAction("AddressIndex");
        }

    }
}