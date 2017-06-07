namespace Cycling.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class restrictionsadded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bicycles", "Model", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Cyclists", "FirstName", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Cyclists", "LastName", c => c.String(nullable: false, maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cyclists", "LastName", c => c.String(maxLength: 40));
            AlterColumn("dbo.Cyclists", "FirstName", c => c.String(maxLength: 40));
            AlterColumn("dbo.Bicycles", "Model", c => c.String(maxLength: 40));
        }
    }
}
