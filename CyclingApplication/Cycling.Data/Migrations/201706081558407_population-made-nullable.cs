namespace Cycling.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populationmadenullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Towns", "Population", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Towns", "Population", c => c.Int(nullable: false));
        }
    }
}
