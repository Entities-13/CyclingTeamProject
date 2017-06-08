namespace Cycling.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fluentapi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Towns", "Name", c => c.String(nullable: false, maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Towns", "Name", c => c.String());
        }
    }
}
