namespace Cycling.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changefKName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GiroDItalias", "Cyclist_id", c => c.Int(nullable: false));
            AddColumn("dbo.TourDeFrances", "Cyclist_id", c => c.Int(nullable: false));
            DropColumn("dbo.GiroDItalias", "IdOfWinner");
            DropColumn("dbo.TourDeFrances", "IdOfWinner");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TourDeFrances", "IdOfWinner", c => c.Int(nullable: false));
            AddColumn("dbo.GiroDItalias", "IdOfWinner", c => c.Int(nullable: false));
            DropColumn("dbo.TourDeFrances", "Cyclist_id");
            DropColumn("dbo.GiroDItalias", "Cyclist_id");
        }
    }
}
