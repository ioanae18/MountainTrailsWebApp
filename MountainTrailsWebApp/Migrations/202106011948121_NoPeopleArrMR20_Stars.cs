namespace MountainTrailsWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoPeopleArrMR20_Stars : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NoPeopleArrMR20Models", "Stars", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NoPeopleArrMR20Models", "Stars");
        }
    }
}
