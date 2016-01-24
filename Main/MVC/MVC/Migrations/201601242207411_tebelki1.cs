namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tebelki1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Achivments", "AchivmentDescription", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Achivments", "AchivmentDescription", c => c.String(maxLength: 60));
        }
    }
}
