namespace Cycling.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnextcyclist : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CylistNexts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BirthDay = c.DateTime(nullable: false),
                        Nationals = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.TourDeFrances", "CylistNext_Id", c => c.Int());
            CreateIndex("dbo.TourDeFrances", "CylistNext_Id");
            AddForeignKey("dbo.TourDeFrances", "CylistNext_Id", "dbo.CylistNexts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TourDeFrances", "CylistNext_Id", "dbo.CylistNexts");
            DropIndex("dbo.TourDeFrances", new[] { "CylistNext_Id" });
            DropColumn("dbo.TourDeFrances", "CylistNext_Id");
            DropTable("dbo.CylistNexts");
        }
    }
}
