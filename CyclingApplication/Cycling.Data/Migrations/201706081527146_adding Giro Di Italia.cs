namespace Cycling.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingGiroDiItalia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GiroDItalias",
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
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.GiroDItalias", new[] { "Year" });
            DropTable("dbo.GiroDItalias");
        }
    }
}
