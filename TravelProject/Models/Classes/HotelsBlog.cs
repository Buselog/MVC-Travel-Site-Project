using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProject.Models.Classes
{
    public class HotelsBlog
    {
        [Key]
        public  int HotelsBlogID{ get; set; }
        public string HotelName { get; set; }
        public string HotelLocation { get; set; }
        public string HotelRating { get; set; }
        public string HotelShortDescription { get; set; }
        public string HotelImageUrl { get; set; }
        public string HotelSiteLink { get; set; }
        public string HotelContactLink { get; set; }

    }
}