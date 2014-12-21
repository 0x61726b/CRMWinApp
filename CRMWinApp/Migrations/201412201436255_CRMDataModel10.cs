namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMDataModel10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attorneys", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.Attorneys", "GraduateSchool", c => c.String());
            AddColumn("dbo.Attorneys", "Picture", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Attorneys", "Picture");
            DropColumn("dbo.Attorneys", "GraduateSchool");
            DropColumn("dbo.Attorneys", "Age");
        }
    }
}
