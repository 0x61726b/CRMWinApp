namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMModel11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agencies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Crimes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        Agency_Id = c.Int(),
                        Criminal_Id = c.Int(),
                        Type_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Agencies", t => t.Agency_Id)
                .ForeignKey("dbo.Criminals", t => t.Criminal_Id)
                .ForeignKey("dbo.CrimeTypes", t => t.Type_Id)
                .Index(t => t.Agency_Id)
                .Index(t => t.Criminal_Id)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.CrimeTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Crimes", "Type_Id", "dbo.CrimeTypes");
            DropForeignKey("dbo.Crimes", "Criminal_Id", "dbo.Criminals");
            DropForeignKey("dbo.Crimes", "Agency_Id", "dbo.Agencies");
            DropIndex("dbo.Crimes", new[] { "Type_Id" });
            DropIndex("dbo.Crimes", new[] { "Criminal_Id" });
            DropIndex("dbo.Crimes", new[] { "Agency_Id" });
            DropTable("dbo.CrimeTypes");
            DropTable("dbo.Crimes");
            DropTable("dbo.Agencies");
        }
    }
}
