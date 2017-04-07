namespace TravelOn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPublished : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Published", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "Published");
        }
    }
}
