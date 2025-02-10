namespace TravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addHotelSiteLinkColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HotelsBlogs", "HotelSiteLink", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.HotelsBlogs", "HotelSiteLink");
        }
    }
}
