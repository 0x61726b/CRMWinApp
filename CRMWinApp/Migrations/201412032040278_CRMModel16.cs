namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMModel16 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Charges", "Arrest_Id", c => c.Int());
            CreateIndex("dbo.Charges", "Arrest_Id");
            AddForeignKey("dbo.Charges", "Arrest_Id", "dbo.Arrests", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Charges", "Arrest_Id", "dbo.Arrests");
            DropIndex("dbo.Charges", new[] { "Arrest_Id" });
            DropColumn("dbo.Charges", "Arrest_Id");
        }
    }
}
