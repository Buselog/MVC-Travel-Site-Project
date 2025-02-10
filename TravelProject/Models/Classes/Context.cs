using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelProject.Models.Classes
{
    public class Context : DbContext
    {

        public DbSet<About> Tbl_About { get; set; }
        public DbSet<Address> Tbl_Address { get; set; }
        public DbSet<Admin> Tbl_Admin { get; set;  }
        public DbSet<Blog> Tbl_Blog { get; set;}
        public DbSet<Comments> Tbl_Comment { get; set; }
        public DbSet<Contact> Tbl_Contact { get; set; }
        public DbSet<Home> Tbl_Home { get; set; }
        public DbSet<HotelsBlog> Tbl_HotelsBlog { get; set; }
        public DbSet<TraditionalFoodsBlog> Tbl_TraditionalFoodsBlog { get; set; }
    }
}