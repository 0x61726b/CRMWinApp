namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMModel5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AuthLevel_Permission",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AuthLevel = c.Int(nullable: false),
                        Permission_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Permissions", t => t.Permission_Id)
                .Index(t => t.Permission_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AuthLevel_Permission", "Permission_Id", "dbo.Permissions");
            DropIndex("dbo.AuthLevel_Permission", new[] { "Permission_Id" });
            DropTable("dbo.AuthLevel_Permission");
        }
    }
}
