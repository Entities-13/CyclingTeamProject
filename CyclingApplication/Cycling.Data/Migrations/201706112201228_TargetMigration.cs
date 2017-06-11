namespace Cycling.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TargetMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GiroDItalias", "CylistNext_Id", c => c.Int());
            CreateIndex("dbo.GiroDItalias", "CylistNext_Id");
            AddForeignKey("dbo.GiroDItalias", "CylistNext_Id", "dbo.CylistNexts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GiroDItalias", "CylistNext_Id", "dbo.CylistNexts");
            DropIndex("dbo.GiroDItalias", new[] { "CylistNext_Id" });
            DropColumn("dbo.GiroDItalias", "CylistNext_Id");
        }
    }
}
