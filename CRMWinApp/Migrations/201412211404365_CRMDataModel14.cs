namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMDataModel14 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Criminals", "Age", c => c.Int(nullable: false));
            AlterColumn("dbo.Criminals", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Criminals", "Surname", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Criminals", "Surname", c => c.String());
            AlterColumn("dbo.Criminals", "Name", c => c.String());
            DropColumn("dbo.Criminals", "Age");
        }
    }
}
