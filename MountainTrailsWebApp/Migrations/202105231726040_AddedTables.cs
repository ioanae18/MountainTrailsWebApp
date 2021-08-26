namespace MountainTrailsWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CountyModels",
                c => new
                    {
                        IdCounty = c.String(nullable: false, maxLength: 128),
                        CountyName = c.String(),
                        CountyAbv = c.String(),
                        IdMountain = c.String(),
                    })
                .PrimaryKey(t => t.IdCounty);
            
            CreateTable(
                "dbo.MountainModels",
                c => new
                    {
                        IdMountain = c.String(nullable: false, maxLength: 128),
                        MountainName = c.String(),
                        IdCounty = c.String(),
                        IdTrail = c.String(),
                        IdPeak = c.String(),
                    })
                .PrimaryKey(t => t.IdMountain);
            
            CreateTable(
                "dbo.PeakModels",
                c => new
                    {
                        IdPeak = c.String(nullable: false, maxLength: 128),
                        Height = c.Int(nullable: false),
                        IdMountain = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.IdPeak)
                .ForeignKey("dbo.MountainModels", t => t.IdMountain)
                .Index(t => t.IdMountain);
            
            CreateTable(
                "dbo.TrailModels",
                c => new
                    {
                        IdTrail = c.String(nullable: false, maxLength: 128),
                        TrailName = c.String(),
                        Duration = c.Int(nullable: false),
                        Distance = c.Int(nullable: false),
                        Climb = c.Int(nullable: false),
                        Descend = c.Int(nullable: false),
                        IdSeason = c.String(),
                        IdDifficulty = c.String(maxLength: 128),
                        IdMarkings = c.String(),
                        IdMountain = c.String(),
                        TrailModels_IdTrail = c.String(maxLength: 128),
                        MarkingModels_IdMarking = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.IdTrail)
                .ForeignKey("dbo.DifficultyModels", t => t.IdDifficulty)
                .ForeignKey("dbo.TrailModels", t => t.TrailModels_IdTrail)
                .ForeignKey("dbo.MarkingModels", t => t.MarkingModels_IdMarking)
                .Index(t => t.IdDifficulty)
                .Index(t => t.TrailModels_IdTrail)
                .Index(t => t.MarkingModels_IdMarking);
            
            CreateTable(
                "dbo.DifficultyModels",
                c => new
                    {
                        IdDifficulty = c.String(nullable: false, maxLength: 128),
                        DifficultyName = c.String(),
                        IdTrail = c.String(),
                    })
                .PrimaryKey(t => t.IdDifficulty);
            
            CreateTable(
                "dbo.SeasonModels",
                c => new
                    {
                        IdSeason = c.String(nullable: false, maxLength: 128),
                        SeasonName = c.String(),
                        IdTrail = c.String(),
                    })
                .PrimaryKey(t => t.IdSeason);
            
            CreateTable(
                "dbo.MarkingModels",
                c => new
                    {
                        IdMarking = c.String(nullable: false, maxLength: 128),
                        MarkingState = c.String(),
                        MarkingDetails = c.String(),
                        IdTrail = c.String(),
                    })
                .PrimaryKey(t => t.IdMarking);
            
            CreateTable(
                "dbo.MountainModelsCountyModels",
                c => new
                    {
                        MountainModels_IdMountain = c.String(nullable: false, maxLength: 128),
                        CountyModels_IdCounty = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.MountainModels_IdMountain, t.CountyModels_IdCounty })
                .ForeignKey("dbo.MountainModels", t => t.MountainModels_IdMountain, cascadeDelete: true)
                .ForeignKey("dbo.CountyModels", t => t.CountyModels_IdCounty, cascadeDelete: true)
                .Index(t => t.MountainModels_IdMountain)
                .Index(t => t.CountyModels_IdCounty);
            
            CreateTable(
                "dbo.TrailModelsMountainModels",
                c => new
                    {
                        TrailModels_IdTrail = c.String(nullable: false, maxLength: 128),
                        MountainModels_IdMountain = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.TrailModels_IdTrail, t.MountainModels_IdMountain })
                .ForeignKey("dbo.TrailModels", t => t.TrailModels_IdTrail, cascadeDelete: true)
                .ForeignKey("dbo.MountainModels", t => t.MountainModels_IdMountain, cascadeDelete: true)
                .Index(t => t.TrailModels_IdTrail)
                .Index(t => t.MountainModels_IdMountain);
            
            CreateTable(
                "dbo.SeasonModelsTrailModels",
                c => new
                    {
                        SeasonModels_IdSeason = c.String(nullable: false, maxLength: 128),
                        TrailModels_IdTrail = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.SeasonModels_IdSeason, t.TrailModels_IdTrail })
                .ForeignKey("dbo.SeasonModels", t => t.SeasonModels_IdSeason, cascadeDelete: true)
                .ForeignKey("dbo.TrailModels", t => t.TrailModels_IdTrail, cascadeDelete: true)
                .Index(t => t.SeasonModels_IdSeason)
                .Index(t => t.TrailModels_IdTrail);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrailModels", "MarkingModels_IdMarking", "dbo.MarkingModels");
            DropForeignKey("dbo.SeasonModelsTrailModels", "TrailModels_IdTrail", "dbo.TrailModels");
            DropForeignKey("dbo.SeasonModelsTrailModels", "SeasonModels_IdSeason", "dbo.SeasonModels");
            DropForeignKey("dbo.TrailModelsMountainModels", "MountainModels_IdMountain", "dbo.MountainModels");
            DropForeignKey("dbo.TrailModelsMountainModels", "TrailModels_IdTrail", "dbo.TrailModels");
            DropForeignKey("dbo.TrailModels", "TrailModels_IdTrail", "dbo.TrailModels");
            DropForeignKey("dbo.TrailModels", "IdDifficulty", "dbo.DifficultyModels");
            DropForeignKey("dbo.PeakModels", "IdMountain", "dbo.MountainModels");
            DropForeignKey("dbo.MountainModelsCountyModels", "CountyModels_IdCounty", "dbo.CountyModels");
            DropForeignKey("dbo.MountainModelsCountyModels", "MountainModels_IdMountain", "dbo.MountainModels");
            DropIndex("dbo.SeasonModelsTrailModels", new[] { "TrailModels_IdTrail" });
            DropIndex("dbo.SeasonModelsTrailModels", new[] { "SeasonModels_IdSeason" });
            DropIndex("dbo.TrailModelsMountainModels", new[] { "MountainModels_IdMountain" });
            DropIndex("dbo.TrailModelsMountainModels", new[] { "TrailModels_IdTrail" });
            DropIndex("dbo.MountainModelsCountyModels", new[] { "CountyModels_IdCounty" });
            DropIndex("dbo.MountainModelsCountyModels", new[] { "MountainModels_IdMountain" });
            DropIndex("dbo.TrailModels", new[] { "MarkingModels_IdMarking" });
            DropIndex("dbo.TrailModels", new[] { "TrailModels_IdTrail" });
            DropIndex("dbo.TrailModels", new[] { "IdDifficulty" });
            DropIndex("dbo.PeakModels", new[] { "IdMountain" });
            DropTable("dbo.SeasonModelsTrailModels");
            DropTable("dbo.TrailModelsMountainModels");
            DropTable("dbo.MountainModelsCountyModels");
            DropTable("dbo.MarkingModels");
            DropTable("dbo.SeasonModels");
            DropTable("dbo.DifficultyModels");
            DropTable("dbo.TrailModels");
            DropTable("dbo.PeakModels");
            DropTable("dbo.MountainModels");
            DropTable("dbo.CountyModels");
        }
    }
}
