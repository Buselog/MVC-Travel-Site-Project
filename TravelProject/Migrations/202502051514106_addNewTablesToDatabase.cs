namespace TravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNewTablesToDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HotelsBlogs",
                c => new
                    {
                        HotelsBlogID = c.Int(nullable: false, identity: true),
                        HotelName = c.String(),
                        HotelLocation = c.String(),
                        HotelRating = c.String(),
                        HotelShortDescription = c.String(),
                        HotelImageUrl = c.String(),
                        HotelContactLink = c.String(),
                    })
                .PrimaryKey(t => t.HotelsBlogID);
            
            CreateTable(
                "dbo.TraditionalFoodsBlogs",
                c => new
                    {
                        TraditionalFoodsBlogID = c.Int(nullable: false, identity: true),
                        TraditionalFoodName = c.String(),
                        TraditionalFoodCountry = c.String(),
                        TraditionalFoodRating = c.String(),
                        TraditionalFoodDescription = c.String(),
                        TraditionalFoodImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.TraditionalFoodsBlogID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TraditionalFoodsBlogs");
            DropTable("dbo.HotelsBlogs");
        }
    }
}
