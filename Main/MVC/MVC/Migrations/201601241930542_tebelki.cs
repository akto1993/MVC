namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tebelki : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Achivments",
                c => new
                    {
                        AchivmentID = c.Int(nullable: false, identity: true),
                        GameID = c.Int(nullable: false),
                        AchivmentTitle = c.String(maxLength: 60),
                        AchivmentDescription = c.String(maxLength: 60),
                    })
                .PrimaryKey(t => t.AchivmentID)
                .ForeignKey("dbo.Games", t => t.GameID, cascadeDelete: true)
                .Index(t => t.GameID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Achivments", "GameID", "dbo.Games");
            DropIndex("dbo.Achivments", new[] { "GameID" });
            DropTable("dbo.Achivments");
        }
    }
}
