using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProject.Models.Classes
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        public string AddressPageTitle { get; set; }
        public string AddressPageDescription { get; set; }
        public string AddressFull { get; set; }
        public string AddressMail { get; set; }

        public string AddressPhone { get; set; }
        public string  AddressLocation { get; set; }

    }
}