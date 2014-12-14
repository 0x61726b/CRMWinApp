namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMModel19 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Charges", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Charges", "Date");
        }
    }
}
