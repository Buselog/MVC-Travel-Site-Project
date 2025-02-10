using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProject.Models.Classes
{
    public class Comments
    {
        [Key]
        public int CommentID { get; set; }
        public string CommentName { get; set; }
        public string CommentMail { get; set; }
        public string Comment { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; } //  relation between a particular blog and its comment


        /*
         
        virtual anahtar kelimesi kullanıldığında, Lazy Loading devreye girer. 
        Yani, ilişkili nesneler yalnızca onlara erişildiği anda yüklenir.
        Eğer virtual kullanılmazsa, ilişkili nesneler hemen yüklenir (Eager Loading), 
        yani ilişkili tüm veriler veritabanından baştan yüklenir.
        Bu sayede, virtual anahtar kelimesi, performans optimizasyonu ve ihtiyaç duyulduğunda verilerin yüklenmesini sağlar. 
        Lazy Loading kullanıldığında, sadece gerektiğinde veriler yüklenir, bu da gereksiz veri çekmenin önüne geçer.
         
         */

    }
}
