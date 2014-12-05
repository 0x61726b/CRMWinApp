namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMModel7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Jeyjey", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Jeyjey");
        }
    }
}
