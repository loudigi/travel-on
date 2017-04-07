namespace TravelOn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDateOBJ : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reviews", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "Title", c => c.String());
        }
    }
}
