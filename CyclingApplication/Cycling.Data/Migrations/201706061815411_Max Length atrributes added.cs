namespace Cycling.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaxLengthatrributesadded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cyclists", "FirstName", c => c.String(maxLength: 40));
            AlterColumn("dbo.Cyclists", "LastName", c => c.String(maxLength: 40));
            AlterColumn("dbo.Cyclists", "CurrentTeam", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cyclists", "CurrentTeam", c => c.String());
            AlterColumn("dbo.Cyclists", "LastName", c => c.String());
            AlterColumn("dbo.Cyclists", "FirstName", c => c.String());
        }
    }
}
