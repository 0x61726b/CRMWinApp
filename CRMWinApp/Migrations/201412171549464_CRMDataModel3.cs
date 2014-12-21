namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMDataModel3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transfers", "TransferGuy_Id", c => c.Int());
            CreateIndex("dbo.Transfers", "TransferGuy_Id");
            AddForeignKey("dbo.Transfers", "TransferGuy_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transfers", "TransferGuy_Id", "dbo.Users");
            DropIndex("dbo.Transfers", new[] { "TransferGuy_Id" });
            DropColumn("dbo.Transfers", "TransferGuy_Id");
        }
    }
}
