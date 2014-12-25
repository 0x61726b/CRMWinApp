namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMDataModel15 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Punishments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                        Criminal_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Criminals", t => t.Criminal_Id)
                .Index(t => t.Criminal_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Punishments", "Criminal_Id", "dbo.Criminals");
            DropIndex("dbo.Punishments", new[] { "Criminal_Id" });
            DropTable("dbo.Punishments");
        }
    }
}
