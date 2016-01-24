namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Platform : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "Platform", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "Platform");
        }
    }
}
