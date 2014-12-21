namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMDataModel12 : DbMigration
    {
        public override void Up()
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
            AlterColumn("dbo.CrimeTypes", "Name", c => c.String(nullable: false));
            CreateIndex("dbo.Charges", "Sentence_Id");
            AddForeignKey("dbo.Charges", "Sentence_Id", "dbo.Sentences", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Charges", "Sentence_Id", "dbo.Sentences");
            DropIndex("dbo.Charges", new[] { "Sentence_Id" });
            AlterColumn("dbo.CrimeTypes", "Name", c => c.String());
            DropColumn("dbo.Charges", "Sentence_Id");
            DropTable("dbo.Sentences");
        }
    }
}
