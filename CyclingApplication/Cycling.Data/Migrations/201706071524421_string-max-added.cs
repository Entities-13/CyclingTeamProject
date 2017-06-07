namespace Cycling.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringmaxadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bicycles", "Wheel_Id", c => c.Int());
            AlterColumn("dbo.Tires", "Brand", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Wheels", "Brand", c => c.String(nullable: false, maxLength: 40));
            CreateIndex("dbo.Bicycles", "Wheel_Id");
            AddForeignKey("dbo.Bicycles", "Wheel_Id", "dbo.Wheels", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bicycles", "Wheel_Id", "dbo.Wheels");
            DropIndex("dbo.Bicycles", new[] { "Wheel_Id" });
            AlterColumn("dbo.Wheels", "Brand", c => c.String());
            AlterColumn("dbo.Tires", "Brand", c => c.String());
            DropColumn("dbo.Bicycles", "Wheel_Id");
        }
    }
}
