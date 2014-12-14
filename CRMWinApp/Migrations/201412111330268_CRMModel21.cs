namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMModel21 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cells",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        Status = c.Boolean(nullable: false),
                        X = c.Int(nullable: false),
                        Y = c.Int(nullable: false),
                        Criminal_Id = c.Int(),
                        Jail_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Criminals", t => t.Criminal_Id)
                .ForeignKey("dbo.Jails", t => t.Jail_Id)
                .Index(t => t.Criminal_Id)
                .Index(t => t.Jail_Id);
            
            CreateTable(
                "dbo.Jails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Location = c.String(),
                        TotalCellCount = c.Int(nullable: false),
                        CurrentPrisonerCount = c.Int(nullable: false),
                        Supervisor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Supervisor_Id)
                .Index(t => t.Supervisor_Id);
            
            CreateTable(
                "dbo.Meetings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Location = c.String(),
                        Outsider_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Outsiders", t => t.Outsider_Id)
                .Index(t => t.Outsider_Id);
            
            CreateTable(
                "dbo.Outsiders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Age = c.Int(nullable: false),
                        Relation = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Criminals", "Jail_Id", c => c.Int());
            CreateIndex("dbo.Criminals", "Jail_Id");
            AddForeignKey("dbo.Criminals", "Jail_Id", "dbo.Jails", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Meetings", "Outsider_Id", "dbo.Outsiders");
            DropForeignKey("dbo.Jails", "Supervisor_Id", "dbo.Users");
            DropForeignKey("dbo.Criminals", "Jail_Id", "dbo.Jails");
            DropForeignKey("dbo.Cells", "Jail_Id", "dbo.Jails");
            DropForeignKey("dbo.Cells", "Criminal_Id", "dbo.Criminals");
            DropIndex("dbo.Meetings", new[] { "Outsider_Id" });
            DropIndex("dbo.Jails", new[] { "Supervisor_Id" });
            DropIndex("dbo.Cells", new[] { "Jail_Id" });
            DropIndex("dbo.Cells", new[] { "Criminal_Id" });
            DropIndex("dbo.Criminals", new[] { "Jail_Id" });
            DropColumn("dbo.Criminals", "Jail_Id");
            DropTable("dbo.Outsiders");
            DropTable("dbo.Meetings");
            DropTable("dbo.Jails");
            DropTable("dbo.Cells");
        }
    }
}
