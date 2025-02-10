using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProject.Models.Classes
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string  ContactName { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public  string ContactEmail { get; set; }
        public string ContactPhone { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank")]
        public string ContactMessage { get; set; }

    }
}