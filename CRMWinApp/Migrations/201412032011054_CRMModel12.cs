namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMModel12 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Crimes", newName: "Arrests");
            CreateTable(
                "dbo.Charges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Against_Id = c.Int(),
                        Attorney_Id = c.Int(),
                        Cite_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Criminals", t => t.Against_Id)
                .ForeignKey("dbo.Attorneys", t => t.Attorney_Id)
                .ForeignKey("dbo.Cites", t => t.Cite_Id)
                .Index(t => t.Against_Id)
                .Index(t => t.Attorney_Id)
                .Index(t => t.Cite_Id);
            
            CreateTable(
                "dbo.Attorneys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Note = c.String(),
                        Officer_Id = c.Int(),
                        Type_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Officer_Id)
                .ForeignKey("dbo.CiteTypes", t => t.Type_Id)
                .Index(t => t.Officer_Id)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.CiteTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Charges", "Cite_Id", "dbo.Cites");
            DropForeignKey("dbo.Cites", "Type_Id", "dbo.CiteTypes");
            DropForeignKey("dbo.Cites", "Officer_Id", "dbo.Users");
            DropForeignKey("dbo.Charges", "Attorney_Id", "dbo.Attorneys");
            DropForeignKey("dbo.Charges", "Against_Id", "dbo.Criminals");
            DropIndex("dbo.Cites", new[] { "Type_Id" });
            DropIndex("dbo.Cites", new[] { "Officer_Id" });
            DropIndex("dbo.Charges", new[] { "Cite_Id" });
            DropIndex("dbo.Charges", new[] { "Attorney_Id" });
            DropIndex("dbo.Charges", new[] { "Against_Id" });
            DropTable("dbo.CiteTypes");
            DropTable("dbo.Cites");
            DropTable("dbo.Attorneys");
            DropTable("dbo.Charges");
            RenameTable(name: "dbo.Arrests", newName: "Crimes");
        }
    }
}
