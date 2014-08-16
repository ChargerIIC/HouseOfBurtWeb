namespace HouseOfBurt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PictureUrlUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "PictureUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Articles", "PictureUrl");
        }
    }
}
