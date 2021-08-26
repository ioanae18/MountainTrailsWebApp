namespace MountainTrailsWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGroupAndDivision : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MountainModels", "Group", c => c.String());
            AddColumn("dbo.MountainModels", "Division", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MountainModels", "Division");
            DropColumn("dbo.MountainModels", "Group");
        }
    }
}
