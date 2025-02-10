using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Classes;

namespace TravelProject.Controllers
{
    public class AdminFoodsBlogController : Controller
    {
        Context db = new Context();

        [Authorize]
        public ActionResult FoodsBlogIndex()
        {
            var values = db.Tbl_TraditionalFoodsBlog.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddNewFood()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewFood(TraditionalFoodsBlog newFood)
        {
            db.Tbl_TraditionalFoodsBlog.Add(newFood);
            db.SaveChanges();
            return RedirectToAction("FoodsBlogIndex");
        }

        public ActionResult DeleteFood(int id)
        {
            var values = db.Tbl_TraditionalFoodsBlog.Find(id);
            db.Tbl_TraditionalFoodsBlog.Remove(values);
            db.SaveChanges();
            return RedirectToAction("FoodsBlogIndex");
        }

        [HttpGet]
        public ActionResult UpdateFood(int id)
        {
            var values = db.Tbl_TraditionalFoodsBlog.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateFood(TraditionalFoodsBlog food)
        {
            var values = db.Tbl_TraditionalFoodsBlog.Find(food.TraditionalFoodsBlogID);
            values.TraditionalFoodName = food.TraditionalFoodName;
            values.TraditionalFoodCountry = food.TraditionalFoodCountry;
            values.TraditionalFoodRating = food.TraditionalFoodRating;
            values.TraditionalFoodDescription = food.TraditionalFoodDescription;
            values.TraditionalFoodImageUrl = food.TraditionalFoodImageUrl;
            db.SaveChanges();
            return RedirectToAction("FoodsBlogIndex");
        }
    }
}