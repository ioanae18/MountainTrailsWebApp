namespace MountainTrailsWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPeakName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PeakModels", "PeakName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PeakModels", "PeakName");
        }
    }
}
