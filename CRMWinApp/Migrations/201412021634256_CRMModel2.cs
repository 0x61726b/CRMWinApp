namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMModel2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "AuthLevel", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "AuthLeve");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "AuthLeve", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "AuthLevel");
        }
    }
}
