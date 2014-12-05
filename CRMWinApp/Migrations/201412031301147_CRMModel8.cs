namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMModel8 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Jeyjey");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Jeyjey", c => c.String());
        }
    }
}
