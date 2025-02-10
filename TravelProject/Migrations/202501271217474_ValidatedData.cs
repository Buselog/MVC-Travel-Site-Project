namespace TravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ValidatedData : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "ContactName", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "ContactEmail", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "ContactMessage", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "ContactMessage", c => c.String());
            AlterColumn("dbo.Contacts", "ContactEmail", c => c.String());
            AlterColumn("dbo.Contacts", "ContactName", c => c.String());
        }
    }
}
