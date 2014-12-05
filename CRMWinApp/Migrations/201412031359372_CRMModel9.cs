namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMModel9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Criminals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Height = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        Gender = c.String(),
                        EyeColor = c.String(),
                        HairColor = c.String(),
                        Race = c.String(),
                        Country = c.String(),
                        State = c.String(),
                        CustodyStart = c.DateTime(nullable: false),
                        CustodyEnd = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Criminals");
        }
    }
}
