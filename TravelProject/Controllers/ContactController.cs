using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Classes;

namespace TravelProject.Controllers
{
    public class ContactController : Controller
    {
        Context db = new Context();
        public ActionResult ContactIndex()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult ContactPartial()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult ContactPartial(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                //return RedirectToAction("ContactIndex", "Contact");
                return View("ContactIndex");
            }

            db.Tbl_Contact.Add(contact);
            db.SaveChanges();
            TempData["SuccessMessage"] = "Your message has been sent successfully!";
            return RedirectToAction("ContactIndex", "Contact");
        }

        public PartialViewResult AddressPartial()
        {
            var values = db.Tbl_Address.ToList();
            return PartialView(values);
        }
    }
}