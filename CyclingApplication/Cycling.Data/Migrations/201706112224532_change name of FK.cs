namespace Cycling.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changenameofFK : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.GiroDItalias", new[] { "CylistNext_Id" });
            DropIndex("dbo.TourDeFrances", new[] { "CylistNext_Id" });
            AlterColumn("dbo.GiroDItalias", "CylistNext_id", c => c.Int(nullable: false));
            AlterColumn("dbo.TourDeFrances", "CylistNext_id", c => c.Int(nullable: false));
            CreateIndex("dbo.GiroDItalias", "CylistNext_Id");
            CreateIndex("dbo.TourDeFrances", "CylistNext_Id");
            DropColumn("dbo.GiroDItalias", "Cyclist_id");
            DropColumn("dbo.TourDeFrances", "Cyclist_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TourDeFrances", "Cyclist_id", c => c.Int(nullable: false));
            AddColumn("dbo.GiroDItalias", "Cyclist_id", c => c.Int(nullable: false));
            DropIndex("dbo.TourDeFrances", new[] { "CylistNext_Id" });
            DropIndex("dbo.GiroDItalias", new[] { "CylistNext_Id" });
            AlterColumn("dbo.TourDeFrances", "CylistNext_id", c => c.Int());
            AlterColumn("dbo.GiroDItalias", "CylistNext_id", c => c.Int());
            CreateIndex("dbo.TourDeFrances", "CylistNext_Id");
            CreateIndex("dbo.GiroDItalias", "CylistNext_Id");
        }
    }
}
