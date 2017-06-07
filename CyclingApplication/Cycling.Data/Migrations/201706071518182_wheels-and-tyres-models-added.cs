namespace Cycling.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class wheelsandtyresmodelsadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tires",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Size = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Wheels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Size = c.Int(nullable: false),
                        Tire_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tires", t => t.Tire_Id)
                .Index(t => t.Tire_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Wheels", "Tire_Id", "dbo.Tires");
            DropIndex("dbo.Wheels", new[] { "Tire_Id" });
            DropTable("dbo.Wheels");
            DropTable("dbo.Tires");
        }
    }
}
