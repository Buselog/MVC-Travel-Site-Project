using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelProject.Models.Classes
{
    public class BlogComments
    {

         //Bir View'a iki farklı tablodan(modelden) veri çekmek için oluşturduğumuz sınıf
        public IEnumerable<Blog> Value1 { get; set; }
        public IEnumerable<Comments> Value2 { get; set; }
        public IEnumerable<Blog> Value3 { get; set; }

    }
}