using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProject.Models.Classes
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public DateTime BlogDate { get; set; }
        public string BlogDescription { get; set; }
        public string BlogImageUrl { get; set; }
        public ICollection<Comments> Comment { get; set; }
    }
}