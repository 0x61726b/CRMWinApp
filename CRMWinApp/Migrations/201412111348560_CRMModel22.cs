namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMModel22 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Meetings", "Criminal_Id", c => c.Int());
            CreateIndex("dbo.Meetings", "Criminal_Id");
            AddForeignKey("dbo.Meetings", "Criminal_Id", "dbo.Criminals", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Meetings", "Criminal_Id", "dbo.Criminals");
            DropIndex("dbo.Meetings", new[] { "Criminal_Id" });
            DropColumn("dbo.Meetings", "Criminal_Id");
        }
    }
}
