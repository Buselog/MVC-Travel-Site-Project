using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProject.Models.Classes
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        public string AdminUser { get; set; }
        public string Password { get; set; }
    }
}