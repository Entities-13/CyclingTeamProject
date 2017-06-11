namespace Cycling.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changenameofCyclistNext : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CylistNexts", newName: "CyclistNexts");
            DropIndex("dbo.GiroDItalias", new[] { "CylistNext_Id" });
            DropIndex("dbo.TourDeFrances", new[] { "CylistNext_Id" });
            RenameColumn(table: "dbo.GiroDItalias", name: "CylistNext_Id", newName: "CyclistNext_Id");
            RenameColumn(table: "dbo.TourDeFrances", name: "CylistNext_Id", newName: "CyclistNext_Id");
            AddColumn("dbo.CyclistNexts", "Nationality", c => c.String());
            AlterColumn("dbo.GiroDItalias", "CyclistNext_Id", c => c.Int());
            AlterColumn("dbo.GiroDItalias", "CyclistNext_id", c => c.Int(nullable: false));
            AlterColumn("dbo.TourDeFrances", "CyclistNext_Id", c => c.Int());
            AlterColumn("dbo.TourDeFrances", "CyclistNext_id", c => c.Int(nullable: false));
            CreateIndex("dbo.GiroDItalias", "CyclistNext_Id");
            CreateIndex("dbo.TourDeFrances", "CyclistNext_Id");
            DropColumn("dbo.CyclistNexts", "Nationals");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CyclistNexts", "Nationals", c => c.String());
            DropIndex("dbo.TourDeFrances", new[] { "CyclistNext_Id" });
            DropIndex("dbo.GiroDItalias", new[] { "CyclistNext_Id" });
            AlterColumn("dbo.TourDeFrances", "CyclistNext_id", c => c.Int());
            AlterColumn("dbo.TourDeFrances", "CyclistNext_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.GiroDItalias", "CyclistNext_id", c => c.Int());
            AlterColumn("dbo.GiroDItalias", "CyclistNext_Id", c => c.Int(nullable: false));
            DropColumn("dbo.CyclistNexts", "Nationality");
            RenameColumn(table: "dbo.TourDeFrances", name: "CyclistNext_Id", newName: "CylistNext_Id");
            RenameColumn(table: "dbo.GiroDItalias", name: "CyclistNext_Id", newName: "CylistNext_Id");
            CreateIndex("dbo.TourDeFrances", "CylistNext_Id");
            CreateIndex("dbo.GiroDItalias", "CylistNext_Id");
            RenameTable(name: "dbo.CyclistNexts", newName: "CylistNexts");
        }
    }
}
