namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMDataModel16 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Charges", "Sentence_Id", "dbo.Sentences");
            DropIndex("dbo.Charges", new[] { "Sentence_Id" });
            DropColumn("dbo.Charges", "Sentence_Id");
            DropTable("dbo.Sentences");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Sentences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Charges", "Sentence_Id", c => c.Int());
            CreateIndex("dbo.Charges", "Sentence_Id");
            AddForeignKey("dbo.Charges", "Sentence_Id", "dbo.Sentences", "Id");
        }
    }
}
