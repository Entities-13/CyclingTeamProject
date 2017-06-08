namespace Cycling.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTouredeFrance : DbMigration
    {
        public override void Up()
        {
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
                    })
                .PrimaryKey(t => t.Id);
            
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
                "dbo.TourDeFrances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.DateTime(nullable: false),
                        Stage = c.Int(nullable: false),
                        Distance = c.Int(nullable: false),
                        TimeOfWinner = c.Time(nullable: false, precision: 7),
                        IdOfWinner = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Year);
            
            CreateTable(
                "dbo.CyclistBicycles",
                c => new
                    {
                        Cyclist_Id = c.Int(nullable: false),
                        Bicycle_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Cyclist_Id, t.Bicycle_Id })
                .ForeignKey("dbo.Cyclists", t => t.Cyclist_Id, cascadeDelete: true)
                .ForeignKey("dbo.Bicycles", t => t.Bicycle_Id, cascadeDelete: true)
                .Index(t => t.Cyclist_Id)
                .Index(t => t.Bicycle_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bicycles", "Wheel_Id", "dbo.Wheels");
            DropForeignKey("dbo.Wheels", "Tire_Id", "dbo.Tires");
            DropForeignKey("dbo.CyclistBicycles", "Bicycle_Id", "dbo.Bicycles");
            DropForeignKey("dbo.CyclistBicycles", "Cyclist_Id", "dbo.Cyclists");
            DropIndex("dbo.CyclistBicycles", new[] { "Bicycle_Id" });
            DropIndex("dbo.CyclistBicycles", new[] { "Cyclist_Id" });
            DropIndex("dbo.TourDeFrances", new[] { "Year" });
            DropIndex("dbo.Wheels", new[] { "Tire_Id" });
            DropIndex("dbo.Bicycles", new[] { "Wheel_Id" });
            DropTable("dbo.CyclistBicycles");
            DropTable("dbo.TourDeFrances");
            DropTable("dbo.Tires");
            DropTable("dbo.Wheels");
            DropTable("dbo.Cyclists");
            DropTable("dbo.Bicycles");
        }
    }
}
