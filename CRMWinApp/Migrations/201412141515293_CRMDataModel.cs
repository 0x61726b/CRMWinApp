namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMDataModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Pass", c => c.String(maxLength: 18));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Pass", c => c.String());
        }
    }
}
