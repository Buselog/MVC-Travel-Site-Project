using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProject.Models.Classes
{
    public class TraditionalFoodsBlog
    {
        [Key]
        public int TraditionalFoodsBlogID { get; set; }
        public string TraditionalFoodName { get; set; }
        public string TraditionalFoodCountry { get; set; }
        public string TraditionalFoodRating { get; set; }
        public string TraditionalFoodDescription { get; set; }
        public string TraditionalFoodImageUrl { get; set; }

    }
}