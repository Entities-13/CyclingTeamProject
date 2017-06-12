namespace Cycling.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        Town_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Towns", t => t.Town_Id)
                .Index(t => t.Town_Id);
            
            CreateTable(
                "dbo.Towns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        Population = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cyclists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 40),
                        LastName = c.String(nullable: false, maxLength: 40),
                        Age = c.Int(nullable: false),
                        TourDeFranceWins = c.Int(nullable: false),
                        GiroDItaliaWins = c.Int(nullable: false),
                        VueltaEspanaWins = c.Int(nullable: false),
                        CurrentTeam = c.String(maxLength: 50),
                        Town_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Towns", t => t.Town_Id)
                .Index(t => t.Town_Id);
            
            CreateTable(
                "dbo.Bicycles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(nullable: false, maxLength: 40),
                        Model = c.String(nullable: false, maxLength: 40),
                        Wheel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Wheels", t => t.Wheel_Id)
                .Index(t => t.Wheel_Id);
            
            CreateTable(
                "dbo.Wheels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(nullable: false, maxLength: 40),
                        Size = c.Int(nullable: false),
                        Tire_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tires", t => t.Tire_Id)
                .Index(t => t.Tire_Id);
            
            CreateTable(
                "dbo.Tires",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(nullable: false, maxLength: 40),
                        Size = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CyclistNexts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 40),
                        LastName = c.String(maxLength: 40),
                        BirthDay = c.DateTime(nullable: false),
                        Nationality = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GiroDItalias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.DateTime(nullable: false),
                        Stage = c.Int(nullable: false),
                        Distance = c.Int(nullable: false),
                        TimeOfWinner = c.Time(nullable: false, precision: 7),
                        CyclistNext_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CyclistNexts", t => t.CyclistNext_Id)
                .Index(t => t.Year)
                .Index(t => t.CyclistNext_Id);
            
            CreateTable(
                "dbo.TourDeFrances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.DateTime(nullable: false),
                        Stage = c.Int(nullable: false),
                        Distance = c.Int(nullable: false),
                        TimeOfWinner = c.Time(nullable: false, precision: 7),
                        CyclistNext_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CyclistNexts", t => t.CyclistNext_Id)
                .Index(t => t.Year)
                .Index(t => t.CyclistNext_Id);
            
            CreateTable(
                "dbo.BicycleCyclists",
                c => new
                    {
                        Bicycle_Id = c.Int(nullable: false),
                        Cyclist_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Bicycle_Id, t.Cyclist_Id })
                .ForeignKey("dbo.Bicycles", t => t.Bicycle_Id, cascadeDelete: true)
                .ForeignKey("dbo.Cyclists", t => t.Cyclist_Id, cascadeDelete: true)
                .Index(t => t.Bicycle_Id)
                .Index(t => t.Cyclist_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TourDeFrances", "CyclistNext_Id", "dbo.CyclistNexts");
            DropForeignKey("dbo.GiroDItalias", "CyclistNext_Id", "dbo.CyclistNexts");
            DropForeignKey("dbo.Addresses", "Town_Id", "dbo.Towns");
            DropForeignKey("dbo.Cyclists", "Town_Id", "dbo.Towns");
            DropForeignKey("dbo.Bicycles", "Wheel_Id", "dbo.Wheels");
            DropForeignKey("dbo.Wheels", "Tire_Id", "dbo.Tires");
            DropForeignKey("dbo.BicycleCyclists", "Cyclist_Id", "dbo.Cyclists");
            DropForeignKey("dbo.BicycleCyclists", "Bicycle_Id", "dbo.Bicycles");
            DropIndex("dbo.BicycleCyclists", new[] { "Cyclist_Id" });
            DropIndex("dbo.BicycleCyclists", new[] { "Bicycle_Id" });
            DropIndex("dbo.TourDeFrances", new[] { "CyclistNext_Id" });
            DropIndex("dbo.TourDeFrances", new[] { "Year" });
            DropIndex("dbo.GiroDItalias", new[] { "CyclistNext_Id" });
            DropIndex("dbo.GiroDItalias", new[] { "Year" });
            DropIndex("dbo.Wheels", new[] { "Tire_Id" });
            DropIndex("dbo.Bicycles", new[] { "Wheel_Id" });
            DropIndex("dbo.Cyclists", new[] { "Town_Id" });
            DropIndex("dbo.Addresses", new[] { "Town_Id" });
            DropTable("dbo.BicycleCyclists");
            DropTable("dbo.TourDeFrances");
            DropTable("dbo.GiroDItalias");
            DropTable("dbo.CyclistNexts");
            DropTable("dbo.Tires");
            DropTable("dbo.Wheels");
            DropTable("dbo.Bicycles");
            DropTable("dbo.Cyclists");
            DropTable("dbo.Towns");
            DropTable("dbo.Addresses");
        }
    }
}
