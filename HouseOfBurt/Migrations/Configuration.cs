using System.Collections.Generic;
using HouseOfBurt.Models;

namespace HouseOfBurt.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HouseOfBurt.Models.DataContext>
    {
        private Category personalCategory;
        private Category softwareCategory;
        private Category webCategory;

        private Link link1;
        private Link link2;
        private Link link3;
        private Link link4;
        private Link link5;
        private Link link6;
        private Link link7;
        private Link link8;
        private Link link9;
        private Link link10;
        private Link link11;

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "HouseOfBurt.Models.DataContext";
        }

        protected override void Seed(DataContext context)
        {
            //  This method will be called after migrating to the latest version.
            seedCategories(context);
            seedLinks(context);
            seedArticles(context);
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
        }

        private void seedLinks(DataContext context)
        {
            context.Links.AddOrUpdate(
                link1 = new Link { LinkId = 1, Caption = "CC Net User Group", URL = "http://www.centralcaldotnet.com/" },
                link2 = new Link { LinkId = 2, Caption = "Jeremy Bytes", URL = "http://jeremybytes.com/" },
                link3 = new Link { LinkId = 3, Caption = "Fresno Google Group", URL = "http://www.meetup.com/googledevelopers/" },
                link4 = new Link { LinkId = 4, Caption = "Get Service Tag Reporter", URL = "http://db.tt/wmDB9FGf" },
                link5 = new Link { LinkId = 5, Caption = "Get HP Warranty Reporter", URL = "http://db.tt/ERPKxCmw" },
                link6 = new Link { LinkId = 6, Caption = "File Zapper Download", URL = "http://db.tt/1QnpzxsV" },
                link7 = new Link { LinkId = 7, Caption = "Monogame", URL = "http://monogame.net/" },
                link8 = new Link { LinkId = 8, Caption = "XNA RPG", URL = "http://xnagpa.net/xna4rpg.php" },
                link9 = new Link { LinkId = 9, Caption = "Monogame Codeplex", URL = "http://monogame.codeplex.com/" },
                link10 = new Link { LinkId = 10, Caption = "Codecademy", URL = "http://www.codecademy.com/" },
                link11 = new Link { LinkId = 11, Caption = "Geekwise Academy", URL = "http://geekwiseacademy.com/" }
                );
        }

        private void seedCategories(DataContext context)
        {
            personalCategory = new Category { Caption = "Personal", CategoryId = 1 };
            softwareCategory = new Category { Caption = "Software", CategoryId = 2 };
            webCategory = new Category { Caption = "Website", CategoryId = 3 };
            context.Categories.AddOrUpdate(personalCategory, softwareCategory, webCategory);
        }

        private void seedArticles(DataContext context)
        {
            context.Articles.AddOrUpdate(
                new Article { ArticleId = 1, Title = "Welcome to the House Of Burt!", Content = Properties.Resources.Article1Content, CreationDate = DateTime.Parse("2012-04-27"), Tags = new List<Category> { webCategory, personalCategory }, Links = new List<Link> { link4, link5 }, PictureUrl = "../Content/img/logo.png" },
                new Article { ArticleId = 2, Title = "Service Tag Reporter 1.4 released", Content = Properties.Resources.Article2Content, CreationDate = DateTime.Parse("2012-04-28"), Tags = new List<Category> { softwareCategory }, Links = new List<Link> { link4 }, PictureUrl = "../Content/img/ServiceTagReporter150.png" },
                new Article { ArticleId = 3, Title = "File Zapper 1.2 released", Content = Properties.Resources.Article3Content, CreationDate = DateTime.Parse("2012-05-12"), Tags = new List<Category> { softwareCategory }, Links = new List<Link> { link6 }, PictureUrl = "../Content/img/FileZapper.png" },
                new Article { ArticleId = 4, Title = "Service Tag Reporter 1.4.1 Released", Content = Properties.Resources.Article4Content, CreationDate = DateTime.Parse("2012-05-12"), Tags = new List<Category> { softwareCategory }, Links = new List<Link> { link4 }, PictureUrl = "../Content/img/ServiceTagReporter150.png" },
                new Article { ArticleId = 5, Title = "HP Warranty Reporter 1.1 released", Content = Properties.Resources.Article5Content, CreationDate = DateTime.Parse("2012-05-14"), Tags = new List<Category> { softwareCategory }, Links = new List<Link> { link5 }, PictureUrl = "../Content/img/HPWarrantyReporter.PNG" },
                new Article { ArticleId = 6, Title = "HP Warranty Reporter 1.1.1 patch released", Content = Properties.Resources.Article6Content, CreationDate = DateTime.Parse("2012-05-29"), Tags = new List<Category> { softwareCategory }, Links = new List<Link> { link5 }, PictureUrl = "../Content/img/HPWarrantyReporter.PNG" },
                new Article { ArticleId = 7, Title = "Service Tag Reporter 1.5 Released", Content = Properties.Resources.Article7Content, CreationDate = DateTime.Parse("2013-09-22"), Tags = new List<Category> { softwareCategory }, Links = new List<Link> { link4 }, PictureUrl = "../Content/img/ServiceTagReporter150.png" },
                new Article { ArticleId = 8, Title = "Starting out in Monogame", Content = Properties.Resources.Article8Content, CreationDate = DateTime.Parse("2013-10-26"), Tags = new List<Category> { personalCategory }, Links = new List<Link> { link1, link3, link7, link8, link9 }, PictureUrl = "../Content/img/MonoGameLogo_512px.png" },
                new Article { ArticleId = 9, Title = "Service Tag Reporter 1.6 Released", Content = Properties.Resources.Article9Content, CreationDate = DateTime.Parse("11/29/2013"), Tags = new List<Category> { softwareCategory }, Links = new List<Link> { link4 }, PictureUrl = "../Content/img/ServiceTagReporter150.png" },
                new Article { ArticleId = 10, Title = "Geekwise Academy", Content = Properties.Resources.Article10Content, CreationDate = DateTime.Parse("12/03/2013"), Tags = new List<Category> { personalCategory }, Links = new List<Link> { link10, link11 }, PictureUrl = "../Content/img/GeekWiseLogo.jpg" }
                //new Article { ArticleId = 11, Title = "New Site: Now Asp.Net!", Content = ContentLocalization.Article11Content, CreationDate = DateTime.Parse("08/10/2014"),Tags = new List<Category> { webCategory }}
                );
        }
    }
}
