namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class wololo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "Platform", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "Platform", c => c.String(maxLength: 4));
        }
    }
}
