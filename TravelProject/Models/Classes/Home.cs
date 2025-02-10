using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProject.Models.Classes
{
    public class Home
    {
        [Key] // set ID as Primary Key
        public int HomeID { get; set; }
        public string HomeTitle { get; set; }
        public  string HomeDescription { get; set; }
    }
}