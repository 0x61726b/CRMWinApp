namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMModel18 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Charges", "Arrest_Id", "dbo.Arrests");
            DropIndex("dbo.Charges", new[] { "Arrest_Id" });
            DropColumn("dbo.Charges", "Arrest_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Charges", "Arrest_Id", c => c.Int());
            CreateIndex("dbo.Charges", "Arrest_Id");
            AddForeignKey("dbo.Charges", "Arrest_Id", "dbo.Arrests", "Id");
        }
    }
}
