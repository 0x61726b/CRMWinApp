namespace CRMWinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMDataModel6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Criminals", "PictureFront", c => c.Binary());
            AddColumn("dbo.Criminals", "PictureLeft", c => c.Binary());
            AddColumn("dbo.Criminals", "PictureRight", c => c.Binary());
            DropColumn("dbo.Criminals", "Picture");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Criminals", "Picture", c => c.Binary());
            DropColumn("dbo.Criminals", "PictureRight");
            DropColumn("dbo.Criminals", "PictureLeft");
            DropColumn("dbo.Criminals", "PictureFront");
        }
    }
}
