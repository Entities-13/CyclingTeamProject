namespace Cycling.Data.Postgre.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Championships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sponsors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SponsorChampionships",
                c => new
                    {
                        Sponsor_Id = c.Int(nullable: false),
                        Championship_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Sponsor_Id, t.Championship_Id })
                .ForeignKey("dbo.Sponsors", t => t.Sponsor_Id, cascadeDelete: true)
                .ForeignKey("dbo.Championships", t => t.Championship_Id, cascadeDelete: true)
                .Index(t => t.Sponsor_Id)
                .Index(t => t.Championship_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SponsorChampionships", "Championship_Id", "dbo.Championships");
            DropForeignKey("dbo.SponsorChampionships", "Sponsor_Id", "dbo.Sponsors");
            DropIndex("dbo.SponsorChampionships", new[] { "Championship_Id" });
            DropIndex("dbo.SponsorChampionships", new[] { "Sponsor_Id" });
            DropTable("dbo.SponsorChampionships");
            DropTable("dbo.Sponsors");
            DropTable("dbo.Championships");
        }
    }
}
