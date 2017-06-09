namespace Cycling.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class properyupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Towns", "Population", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Towns", "Population");
        }
    }
}
