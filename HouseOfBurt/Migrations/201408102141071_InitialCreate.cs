namespace HouseOfBurt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ArticleId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ArticleId);
            
            CreateTable(
                "dbo.Links",
                c => new
                    {
                        LinkId = c.Int(nullable: false, identity: true),
                        Caption = c.String(),
                        URL = c.String(),
                        Article_ArticleId = c.Int(),
                    })
                .PrimaryKey(t => t.LinkId)
                .ForeignKey("dbo.Articles", t => t.Article_ArticleId)
                .Index(t => t.Article_ArticleId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Caption = c.String(),
                        Article_ArticleId = c.Int(),
                    })
                .PrimaryKey(t => t.CategoryId)
                .ForeignKey("dbo.Articles", t => t.Article_ArticleId)
                .Index(t => t.Article_ArticleId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IconUrl = c.String(),
                        ImageUrl = c.String(),
                        Description = c.String(),
                        SourceLink_LinkId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Links", t => t.SourceLink_LinkId)
                .Index(t => t.SourceLink_LinkId);
            
            CreateTable(
                "dbo.Versions",
                c => new
                    {
                        VersionId = c.Int(nullable: false, identity: true),
                        VersionNumber = c.String(),
                        ReleaseNotes = c.String(),
                        DownloadLink_LinkId = c.Int(),
                        Product_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.VersionId)
                .ForeignKey("dbo.Links", t => t.DownloadLink_LinkId)
                .ForeignKey("dbo.Products", t => t.Product_ProductId)
                .Index(t => t.DownloadLink_LinkId)
                .Index(t => t.Product_ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Versions", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.Versions", "DownloadLink_LinkId", "dbo.Links");
            DropForeignKey("dbo.Products", "SourceLink_LinkId", "dbo.Links");
            DropForeignKey("dbo.Categories", "Article_ArticleId", "dbo.Articles");
            DropForeignKey("dbo.Links", "Article_ArticleId", "dbo.Articles");
            DropIndex("dbo.Versions", new[] { "Product_ProductId" });
            DropIndex("dbo.Versions", new[] { "DownloadLink_LinkId" });
            DropIndex("dbo.Products", new[] { "SourceLink_LinkId" });
            DropIndex("dbo.Categories", new[] { "Article_ArticleId" });
            DropIndex("dbo.Links", new[] { "Article_ArticleId" });
            DropTable("dbo.Versions");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
            DropTable("dbo.Links");
            DropTable("dbo.Articles");
        }
    }
}
