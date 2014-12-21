namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMDataModel2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transfers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Criminal_Id = c.Int(),
                        From_Id = c.Int(),
                        To_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Criminals", t => t.Criminal_Id)
                .ForeignKey("dbo.Cells", t => t.From_Id)
                .ForeignKey("dbo.Cells", t => t.To_Id)
                .Index(t => t.Criminal_Id)
                .Index(t => t.From_Id)
                .Index(t => t.To_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transfers", "To_Id", "dbo.Cells");
            DropForeignKey("dbo.Transfers", "From_Id", "dbo.Cells");
            DropForeignKey("dbo.Transfers", "Criminal_Id", "dbo.Criminals");
            DropIndex("dbo.Transfers", new[] { "To_Id" });
            DropIndex("dbo.Transfers", new[] { "From_Id" });
            DropIndex("dbo.Transfers", new[] { "Criminal_Id" });
            DropTable("dbo.Transfers");
        }
    }
}
