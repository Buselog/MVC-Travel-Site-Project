using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProject.Models.Classes
{

    //-About Page- class for Code First Approach

    public class About
    {
        [Key]  // set ID as primary key
        public int AboutID { get; set; }
        public string AboutImageUrl { get; set; }
        public string AboutDescription { get; set; }
    }
}

