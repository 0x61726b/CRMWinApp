namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMDataModel5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Criminals", "Picture", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Criminals", "Picture");
        }
    }
}
