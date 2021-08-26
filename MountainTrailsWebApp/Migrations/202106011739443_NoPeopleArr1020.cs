namespace MountainTrailsWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoPeopleArr1020 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NoPeopleArr1020Models",
                c => new
                    {
                        ArrivalId = c.String(nullable: false, maxLength: 128),
                        Hotels = c.Int(nullable: false),
                        Hostels = c.Int(nullable: false),
                        Motels = c.Int(nullable: false),
                        Hans = c.Int(nullable: false),
                        Villas = c.Int(nullable: false),
                        Cabins = c.Int(nullable: false),
                        Campings = c.Int(nullable: false),
                        Stops = c.Int(nullable: false),
                        Pensions = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArrivalId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NoPeopleArr1020Models");
        }
    }
}
