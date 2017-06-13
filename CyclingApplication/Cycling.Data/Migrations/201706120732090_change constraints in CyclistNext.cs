namespace Cycling.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeconstraintsinCyclistNext : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.GiroDItalias", new[] { "CyclistNext_Id" });
            DropIndex("dbo.TourDeFrances", new[] { "CyclistNext_Id" });
            AlterColumn("dbo.CyclistNexts", "FirstName", c => c.String(maxLength: 40));
            AlterColumn("dbo.CyclistNexts", "LastName", c => c.String(maxLength: 40));
            AlterColumn("dbo.CyclistNexts", "Nationality", c => c.String(maxLength: 40));
            AlterColumn("dbo.GiroDItalias", "CyclistNext_Id", c => c.Int());
            AlterColumn("dbo.GiroDItalias", "CyclistNext_id", c => c.Int(nullable: false));
            AlterColumn("dbo.TourDeFrances", "CyclistNext_Id", c => c.Int());
            AlterColumn("dbo.TourDeFrances", "CyclistNext_id", c => c.Int(nullable: false));
            CreateIndex("dbo.GiroDItalias", "CyclistNext_Id");
            CreateIndex("dbo.TourDeFrances", "CyclistNext_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.TourDeFrances", new[] { "CyclistNext_Id" });
            DropIndex("dbo.GiroDItalias", new[] { "CyclistNext_Id" });
            AlterColumn("dbo.TourDeFrances", "CyclistNext_id", c => c.Int());
            AlterColumn("dbo.TourDeFrances", "CyclistNext_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.GiroDItalias", "CyclistNext_id", c => c.Int());
            AlterColumn("dbo.GiroDItalias", "CyclistNext_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.CyclistNexts", "Nationality", c => c.String());
            AlterColumn("dbo.CyclistNexts", "LastName", c => c.String());
            AlterColumn("dbo.CyclistNexts", "FirstName", c => c.String());
            CreateIndex("dbo.TourDeFrances", "CyclistNext_Id");
            CreateIndex("dbo.GiroDItalias", "CyclistNext_Id");
        }
    }
}
