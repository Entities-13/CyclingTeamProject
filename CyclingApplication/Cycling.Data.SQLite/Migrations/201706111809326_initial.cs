namespace Cycling.Data.SQLite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CyclingDestinations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Country = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CyclingInstructors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Country = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.History_82c009b41631-48579635f1ff64eb62d9",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Hash = c.String(nullable: false),
                        Context = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CyclingInstructorCyclingDestinations",
                c => new
                    {
                        CyclingInstructor_Id = c.Int(nullable: false),
                        CyclingDestination_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CyclingInstructor_Id, t.CyclingDestination_Id })
                .ForeignKey("dbo.CyclingInstructors", t => t.CyclingInstructor_Id, cascadeDelete: true)
                .ForeignKey("dbo.CyclingDestinations", t => t.CyclingDestination_Id, cascadeDelete: true)
                .Index(t => t.CyclingInstructor_Id, name: "IX_CyclingInstructorCyclingDestination_CyclingInstructor_Id")
                .Index(t => t.CyclingDestination_Id, name: "IX_CyclingInstructorCyclingDestination_CyclingDestination_Id");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CyclingInstructorCyclingDestinations", "CyclingDestination_Id", "dbo.CyclingDestinations");
            DropForeignKey("dbo.CyclingInstructorCyclingDestinations", "CyclingInstructor_Id", "dbo.CyclingInstructors");
            DropIndex("dbo.CyclingInstructorCyclingDestinations", "IX_CyclingInstructorCyclingDestination_CyclingDestination_Id");
            DropIndex("dbo.CyclingInstructorCyclingDestinations", "IX_CyclingInstructorCyclingDestination_CyclingInstructor_Id");
            DropTable("dbo.CyclingInstructorCyclingDestinations");
            DropTable("dbo.History_82c009b41631-48579635f1ff64eb62d9");
            DropTable("dbo.CyclingInstructors");
            DropTable("dbo.CyclingDestinations");
        }
    }
}
