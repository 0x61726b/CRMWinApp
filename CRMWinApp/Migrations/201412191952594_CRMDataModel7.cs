namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMDataModel7 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Criminals", "CustodyStart");
            DropColumn("dbo.Criminals", "CustodyEnd");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Criminals", "CustodyEnd", c => c.DateTime(nullable: false));
            AddColumn("dbo.Criminals", "CustodyStart", c => c.DateTime(nullable: false));
        }
    }
}
