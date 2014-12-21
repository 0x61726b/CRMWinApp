namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMDataModel4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cells", "Width", c => c.Int(nullable: false));
            AddColumn("dbo.Cells", "Height", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cells", "Height");
            DropColumn("dbo.Cells", "Width");
        }
    }
}
