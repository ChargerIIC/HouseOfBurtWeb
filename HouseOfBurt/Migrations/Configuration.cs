using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Web.Services.Description;
using HouseOfBurt.Models;

namespace HouseOfBurt.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataContext>
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
        private Link link12;
        private Link link13;
        private Link link14;
        private Link link15;
        private Link link16;
        private Link link17;
        private Link link18;

        private Product serviceTag;
        private Product hpWarranty;
        private Product fileZap;
        private Product dealORound;

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "HouseOfBurt.DataContext";
        }

        protected override void Seed(DataContext context)
        {
            //  This method will be called after migrating to the latest version.
            seedCategories(context);
            seedLinks(context);
            seedArticles(context);
            seedProducts(context);
            seedApplications(context);
            seedApplicationData(context);
        }

        private void seedProducts(DataContext context)
        {
            serviceTag = new Product
            {
                ProductId = 1,
                Slug = "Service-Tag-Reporter",
                ImageUrl = @"../Content/img/ServiceTagReporter150.png",
                Description = Properties.Resources.ServiceTagDescription,
                ShortDescription = Properties.Resources.ServiceTagShortDescription,
                SourceLink = link4,
                Keywords = "service tag reporter software utility download dell warranty",
                Versions = new List<Models.Version>
                {
                    new Models.Version
                    {
                        VersionId = 1,
                        VersionNumber = "1.0.0.0",
                        ReleaseNotes = Properties.Resources.ServiceTagVersion1
                    },
                    new Models.Version
                    {
                        VersionId = 2,
                        VersionNumber = "1.1.0.0",
                        ReleaseNotes = Properties.Resources.ServiceTagVersion2
                    },
                    new Models.Version
                    {
                        VersionId = 3,
                        VersionNumber = "1.1.0.1",
                        ReleaseNotes = Properties.Resources.ServiceTagVersion3
                    },
                    new Models.Version
                    {
                        VersionId = 4,
                        VersionNumber = "1.1.2.0",
                        ReleaseNotes = Properties.Resources.ServiceTagVersion4
                    },
                    new Models.Version
                    {
                        VersionId = 5,
                        VersionNumber = "1.1.3.0",
                        ReleaseNotes = Properties.Resources.ServiceTagVersion5
                    },
                    new Models.Version
                    {
                        VersionId = 6,
                        VersionNumber = "1.4.0.0",
                        ReleaseNotes = Properties.Resources.ServiceTagVersion6
                    },
                    new Models.Version
                    {
                        VersionId = 8,
                        VersionNumber = "1.4.1.0",
                        ReleaseNotes = Properties.Resources.ServiceTagVersion7
                    },
                    new Models.Version
                    {
                        VersionId = 9,
                        VersionNumber = "1.4.1.1",
                        ReleaseNotes = Properties.Resources.ServiceTagVersion8
                    },
                    new Models.Version
                    {
                        VersionId = 10,
                        VersionNumber = "1.5.0.0",
                        ReleaseNotes = Properties.Resources.ServiceTagVersion9
                    },
                    new Models.Version
                    {
                        VersionId = 12,
                        VersionNumber = "1.6.0.0",
                        ReleaseNotes = Properties.Resources.ServiceTagVersion10
                    }
                }
            };
            hpWarranty = new Product
            {
                ProductId = 2,
                Slug = "HP-Warranty-Reporter",
                ImageUrl = @"../Content/img/HPWarrantyReporter.png",
                Description = Properties.Resources.HpWarrantyDescription,
                ShortDescription = Properties.Resources.HpWarrantyShortDescription,
                Keywords = "hp warranty reporter download software utlity IT",
                SourceLink = link5,
                Versions =
                    new List<Models.Version>
                    {
                        new Models.Version
                        {
                            VersionId = 11,
                            VersionNumber = "1.1.1",
                            ReleaseNotes = Properties.Resources.HpWarrantyVersion1
                        }
                    }
            };
            fileZap = new Product
            {
                ProductId = 3,
                Slug = "File-Zapper",
                ImageUrl = @"../Content/img/FileZapper.png",
                Description = Properties.Resources.FileZapperDescription,
                ShortDescription = Properties.Resources.FileZapperShortDescription,
                Keywords = "filezapper delete network files download utility software",
                SourceLink = link6,
                Versions =
                    new List<Models.Version>
                    {
                        new Models.Version {VersionId = 13, VersionNumber = "1.0.0", ReleaseNotes = "Intial Version"}
                    }
            };
            dealORound = new Product
            {
                ProductId = 4,
                Slug = "Deal-O-Round",
                ImageUrl = "../Content/img/DealORound.jpg",
                Description = Properties.Resources.DealORoundDescription,
                ShortDescription = Properties.Resources.DealORoundShortDescription,
                Keywords = "dealoround poker playn game java development"
            };
            context.Products.AddOrUpdate(serviceTag, hpWarranty, fileZap, dealORound);
        }

        private void seedApplications(DataContext context)
        {
            context.WebApplications.AddOrUpdate(
                new Application{ ApplicationId = 1, Action="ContextIsNeeded", Name="Context is Needed", Description="ContextIsNeeded is a web application that points out some of the foibles in the famous StackExchange network. Curated questions are presented without context, leading the user to wonder just what are they asking over there. Questions are pulled from throughout the network, including StackOverflow, Gaming, and Workplace exchanges."},
                new Application{ ApplicationId = 2, Action = "FresnoPopulationMap", Name = "Fresno Population Map", Description="A simple map that displays Fresno's population density. Larger circles indicate a more 'dense' population area. Application is location-aware"});
        }

        private void seedLinks(DataContext context)
        {
            context.Links.AddOrUpdate(
                link1 = new Link { LinkId = 1, Caption = "CC Net User Group", URL = "http://www.centralcaldotnet.com/" },
                link2 = new Link { LinkId = 2, Caption = "Jeremy Bytes", URL = "http://jeremybytes.com/" },
                link3 = new Link { LinkId = 3, Caption = "Fresno Google Group", URL = "http://www.meetup.com/googledevelopers/" },
                link4 = new Link { LinkId = 4, Caption = "Get Service Tag Reporter", URL = "http://db.tt/wmDB9FGf" },
                link5 = new Link { LinkId = 5, Caption = "Get HP Warranty Reporter", URL = "http://db.tt/ERPKxCmw" },
                link6 = new Link { LinkId = 6, Caption = "Get File Zapper", URL = "http://db.tt/1QnpzxsV" },
                link7 = new Link { LinkId = 7, Caption = "Monogame", URL = "http://monogame.net/" },
                link8 = new Link { LinkId = 8, Caption = "XNA RPG", URL = "http://xnagpa.net/xna4rpg.php" },
                link9 = new Link { LinkId = 9, Caption = "Monogame Codeplex", URL = "http://monogame.codeplex.com/" },
                link10 = new Link { LinkId = 10, Caption = "Codecademy", URL = "http://www.codecademy.com/" },
                link11 = new Link { LinkId = 11, Caption = "Geekwise Academy", URL = "http://geekwiseacademy.com/" },
                link12 = new Link { LinkId = 12, Caption = "Deal O Round", URL = "http://dealoround.com" },
                link13 = new Link { LinkId = 13, Caption = "Context Is Needed", URL="http://www.contextisneeded.com"},
                link14 = new Link { LinkId = 14, Caption = "Stack Exchange", URL = "http://stackexchange.com" },
                link15 = new Link { LinkId = 15, Caption = "Jquery Backstretch", URL="http://srobbin.com/jquery-plugins/backstretch/"},
                link16 = new Link { LinkId = 16, Caption = "Design For Hackers", URL = "http://designforhackers.com/" },
                link17 = new Link { LinkId = 17, Caption = "Crystal Reports SDK", URL = "http://scn.sap.com/docs/DOC-35632" },
                link18 = new Link { LinkId = 18, Caption = "Crystal Reports", URL = "http://www.crystalreports.com/" }
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
                new Article { ArticleId = 1, Slug = "Welcome-to-the-House-Of-Burt!", Keywords = "Welcome House Of Burt Launch",Content = Properties.Resources.Article1Content, CreationDate = DateTime.Parse("2012-04-27"), Tags = new List<Category> { webCategory, personalCategory }, Links = new List<Link> { link4, link5 }, PictureUrl = "../Content/img/logo.png" },
                new Article { ArticleId = 2, Slug = "Service-Tag-Reporter-1.4-released", Keywords = "Service Tag Reporter News 1.4",Content = Properties.Resources.Article2Content, CreationDate = DateTime.Parse("2012-04-28"), Tags = new List<Category> { softwareCategory }, Links = new List<Link> { link4 }, PictureUrl = "../Content/img/ServiceTagReporter150.png" },
                new Article { ArticleId = 3, Slug = "File-Zapper-1.2-released", Keywords = "File Zapper 1.2 News",Content = Properties.Resources.Article3Content, CreationDate = DateTime.Parse("2012-05-12"), Tags = new List<Category> { softwareCategory }, Links = new List<Link> { link6 }, PictureUrl = "../Content/img/FileZapper.png" },
                new Article { ArticleId = 4, Slug = "Service-Tag-Reporter-1.4.1-Released",Keywords = "Service Tag Reporter News 1.4.1 patch", Content = Properties.Resources.Article4Content, CreationDate = DateTime.Parse("2012-05-12"), Tags = new List<Category> { softwareCategory }, Links = new List<Link> { link4 }, PictureUrl = "../Content/img/ServiceTagReporter150.png" },
                new Article { ArticleId = 5, Slug = "HP-Warranty-Reporter-1.1-released",Keywords = "HP Warranty Reporter News 1.1", Content = Properties.Resources.Article5Content, CreationDate = DateTime.Parse("2012-05-14"), Tags = new List<Category> { softwareCategory }, Links = new List<Link> { link5 }, PictureUrl = "../Content/img/HPWarrantyReporter.PNG" },
                new Article { ArticleId = 6, Slug = "HP-Warranty-Reporter-1.1.1-patch-released", Keywords = "HP Warranty Reporter News 1.1.1", Content = Properties.Resources.Article6Content, CreationDate = DateTime.Parse("2012-05-29"), Tags = new List<Category> { softwareCategory }, Links = new List<Link> { link5 }, PictureUrl = "../Content/img/HPWarrantyReporter.PNG" },
                new Article { ArticleId = 7, Slug = "Service-Tag-Reporter-1.5-Released", Keywords = "Service Tag Reporter News 1.5 release", Content = Properties.Resources.Article7Content, CreationDate = DateTime.Parse("2013-09-22"), Tags = new List<Category> { softwareCategory }, Links = new List<Link> { link4 }, PictureUrl = "../Content/img/ServiceTagReporter150.png" },
                new Article { ArticleId = 8, Slug = "Starting-out-in-Monogame", Keywords = "Monogame developement C# getting started how work", Content = Properties.Resources.Article8Content, CreationDate = DateTime.Parse("2013-10-26"), Tags = new List<Category> { personalCategory }, Links = new List<Link> { link1, link3, link7, link8, link9 }, PictureUrl = "../Content/img/MonoGameLogo_512px.png" },
                new Article { ArticleId = 9, Slug = "Service-Tag-Reporter-1.6-Released", Keywords = "Service Tag Reporter 1.6 news release", Content = Properties.Resources.Article9Content, CreationDate = DateTime.Parse("11/29/2013"), Tags = new List<Category> { softwareCategory }, Links = new List<Link> { link4 }, PictureUrl = "../Content/img/ServiceTagReporter150.png" },
                new Article { ArticleId = 10, Slug = "Geekwise-Academy", Keywords = "Geekwise Academy Review testimonial fresno ca", Content = Properties.Resources.Article10Content, CreationDate = DateTime.Parse("12/03/2013"), Tags = new List<Category> { personalCategory }, Links = new List<Link> { link10, link11 }, PictureUrl = "../Content/img/GeekWiseLogo.jpg" },
                new Article { ArticleId = 11, Slug = "Migrating-from-Django-to-Asp-MVC", Keywords = "migration django asp c# python", Content = Properties.Resources.Article11Content, CreationDate = DateTime.Parse("08/10/2014"),Tags = new List<Category> { webCategory }, PictureUrl = "../Content/img/asp-net-logo.png"},
                new Article { ArticleId = 12, Slug = "Context-Is-Needed-Launch", Keywords = "ContextIsNeeded StackExchange funny stupid questions", Content = Properties.Resources.Article12Content, CreationDate = new DateTime(2014, 09, 14), Tags = new List<Category> { webCategory, softwareCategory }, Links = new List<Link> { link13, link14, link15, link16 }, PictureUrl = "../Content/img/Context_Is_Needed.jpg" },
                new Article { ArticleId = 13, Slug = "How-To-Programmaticly-Detect-Ufls-In-Crystal-Reports", Keywords = "crystal reports ufl c# tutorial detect", Content = Properties.Resources.Article13Content, CreationDate = new DateTime(2014, 10, 14), Tags = new List<Category> { softwareCategory}, Links = new List<Link>{ link17, link18}, PictureUrl = "../Content/img/CrystalFormula.png"}
                );
        }

        private void seedApplicationData(DataContext context)
        {
            context.ContextIsNeededQuestions.AddOrUpdate(
                new ContextIsNeeded_Question
                {
                    QuestionId = 41,
                    Caption = "How do I make it absolutely clear that I'm shooting you in the face?",
                    Url =
                        "http://rpg.stackexchange.com/questions/46889/how-do-i-make-it-absolutely-clear-that-im-shooting-you-in-the-face"
                },
                new ContextIsNeeded_Question
                {
                    QuestionId = 40,
                    Caption = "How can I get my wife to stop nagging about a few murders?",
                    Url =
                        "http://gaming.stackexchange.com/questions/39411/how-can-i-get-my-wife-to-stop-nagging-about-a-few-murders"
                },
                new ContextIsNeeded_Question
                {
                    QuestionId = 39,
                    Caption = "Can I pass out from excessive drinking? ",
                    Url = "http://gaming.stackexchange.com/questions/9768/can-i-pass-out-from-excessive-drinking"
                },
                new ContextIsNeeded_Question
                {
                    QuestionId = 38,
                    Caption = "How can I tell if a corpse is safe to eat? ",
                    Url = "http://gaming.stackexchange.com/questions/4999/how-can-i-tell-if-a-corpse-is-safe-to-eat"
                },
                new ContextIsNeeded_Question
                {
                    QuestionId = 37,
                    Caption = "How can I keep monsters out of my nether regions?",
                    Url =
                        "http://gaming.stackexchange.com/questions/14605/how-can-i-keep-monsters-out-of-my-nether-regions"
                },
                new ContextIsNeeded_Question
                {
                    QuestionId = 36,
                    Caption = "My children are useless. What should I do?",
                    Url = "http://gaming.stackexchange.com/questions/18376/my-children-are-useless-what-should-i-do"
                },
                new ContextIsNeeded_Question
                {
                    QuestionId = 35,
                    Caption = "Al Gore won't leave me alone. How do I unfriend him on Facebook?",
                    Url =
                        "http://gaming.stackexchange.com/questions/158984/al-gore-wont-leave-me-alone-how-do-i-unfriend-someone-on-facebook"
                },
                new ContextIsNeeded_Question
                {
                    QuestionId = 34,
                    Caption = "How do I cook meth? ",
                    Url = "http://gaming.stackexchange.com/q/130335/52800"
                },
                new ContextIsNeeded_Question
                {
                    QuestionId = 33,
                    Caption = "How do I lick a plane?",
                    Url = "http://gaming.stackexchange.com/questions/162789/how-do-i-lick-a-plane"
                },
                new ContextIsNeeded_Question
                {
                    QuestionId = 32,
                    Caption = "How can I increase my chances of getting cancer?",
                    Url =
                        "http://gaming.stackexchange.com/questions/169544/how-can-i-increase-my-chances-of-getting-cancer"
                },
                new ContextIsNeeded_Question
                {
                    QuestionId = 31,
                    Caption = "One of my cooks died, how do I get rid of the corpse?",
                    Url =
                        "http://gaming.stackexchange.com/questions/167223/one-of-my-cooks-died-how-do-i-get-rid-of-the-corpse"
                },
                new ContextIsNeeded_Question
                {
                    QuestionId = 30,
                    Caption = "What is the fastest way to kill my family?",
                    Url = "http://gaming.stackexchange.com/questions/139127/what-is-the-fastest-way-to-kill-my-family"
                },
                new ContextIsNeeded_Question
                {
                    QuestionId = 29,
                    Caption = "Will sleeping with my sons wife have a negative effect on our relationship?",
                    Url =
                        "http://gaming.stackexchange.com/questions/174371/will-sleeping-with-my-sons-wife-have-a-negative-effect-on-our-relationship"
                },
                new ContextIsNeeded_Question
                {
                    QuestionId = 28,
                    Caption = "How can I find lesbians?",
                    Url = "http://gaming.stackexchange.com/questions/34804/how-can-i-find-lesbians"
                },
                new ContextIsNeeded_Question
                {
                    QuestionId = 27,
                    Caption = "How do I take off my pants?",
                    Url = "http://gaming.stackexchange.com/questions/120663/how-do-i-take-off-my-pants"
                },
                new ContextIsNeeded_Question
                {
                    QuestionId = 26,
                    Caption = "Can I kill everybody?",
                    Url = "http://gaming.stackexchange.com/questions/13892/can-i-kill-everybody"
                },
                new ContextIsNeeded_Question
                {
                    QuestionId = 25,
                    Caption = "What is the point of having friends?",
                    Url = "http://gaming.stackexchange.com/questions/182194/what-is-the-point-of-having-friends"
                },
                new ContextIsNeeded_Question { QuestionId= 1,Caption = "What is the terminal velocity of a sheep?", Url = "http://gaming.stackexchange.com/questions/178726/what-is-the-terminal-velocity-of-a-sheep" },
                new ContextIsNeeded_Question { QuestionId= 2,Caption = "What are the consequences of accepting unknown substances from strange men?", Url = "http://gaming.stackexchange.com/questions/23361/what-are-the-consequences-of-accepting-unknown-substances-from-strange-men" },
                new ContextIsNeeded_Question { QuestionId= 3,Caption = "Why did my dog just eat my cat?", Url = "http://gaming.stackexchange.com/q/17067/8366" },
                new ContextIsNeeded_Question { QuestionId= 4,Caption = "Does hitting a sheep in the face yield more wool? ", Url = "http://gaming.stackexchange.com/questions/24696/does-hitting-a-sheep-in-the-face-yield-more-wool" },
                new ContextIsNeeded_Question { QuestionId= 5,Caption = "How do I Know if I'm Dead? ", Url = "http://gaming.stackexchange.com/questions/11455/how-do-i-know-if-im-dead" },
                new ContextIsNeeded_Question { QuestionId= 6,Caption = "When is it a good idea to punch people?", Url = "http://gaming.stackexchange.com/questions/152166/when-is-it-a-good-idea-to-punch-people" },
                new ContextIsNeeded_Question { QuestionId= 7,Caption = "Can Vegans eat Jewelry?", Url = "http://gaming.stackexchange.com/questions/164898/can-vegans-eat-jewelry" },
                new ContextIsNeeded_Question { QuestionId= 8,Caption = "Why did this explosion make me fat?", Url = "http://gaming.stackexchange.com/questions/165084/why-did-this-explosion-make-me-fat-a-land-mine-increased-my-weight" },
                new ContextIsNeeded_Question { QuestionId= 9,Caption = "Is it a good idea to put on yellow dragon scale mail and go to town with a rubber chicken?", Url = "http://gaming.stackexchange.com/questions/142966/is-it-a-good-idea-to-put-on-yellow-dragon-scale-mail-and-go-to-town-with-a-rubbe" },
                new ContextIsNeeded_Question { QuestionId= 10,Caption = "Can I eat humans and sacrifice them to my god?", Url = "http://gaming.stackexchange.com/questions/86004/can-i-eat-humans-and-sacrifice-them-to-my-god" },
                new ContextIsNeeded_Question { QuestionId= 11,Caption = "What race should I genocide?", Url = "http://gaming.stackexchange.com/questions/17030/what-race-should-i-genocide" },
                new ContextIsNeeded_Question { QuestionId= 12,Caption = "Why does Windows think that my wireless keyboard is a toaster?", Url = "http://superuser.com/questions/792607/why-does-windows-think-that-my-wireless-keyboard-is-a-toaster" },
                new ContextIsNeeded_Question { QuestionId= 13,Caption = "My head keeps falling off. What can I do?", Url = "http://gaming.stackexchange.com/questions/37805/my-head-keeps-falling-off-what-can-i-do" },
                new ContextIsNeeded_Question { QuestionId= 14,Caption = "Why do I stop eating corpses? Should I keep eating them anyway?", Url = "http://gaming.stackexchange.com/questions/159747/why-do-i-stop-eating-corpses-should-i-keep-eating-them-anyway" },
                new ContextIsNeeded_Question { QuestionId= 15,Caption = "Why does Ghandi want to nuke me?", Url = "http://gaming.stackexchange.com/questions/58009/why-does-ghandi-want-to-nuke-me" },
                new ContextIsNeeded_Question { QuestionId= 16,Caption = "Why does my wedding turn into a brawl?", Url = "http://gaming.stackexchange.com/questions/118490/why-does-my-wedding-turn-into-a-brawl" },
                new ContextIsNeeded_Question { QuestionId= 17,Caption = "How to create and run a realistic cult?", Url = "http://rpg.stackexchange.com/questions/44574/how-to-create-and-run-a-realistic-cult" },
                new ContextIsNeeded_Question { QuestionId= 18,Caption = "I'm looking to stab someone. What weapon should I pick?", Url = "http://gaming.stackexchange.com/questions/109349/im-looking-to-stab-someone-what-weapon-should-i-pick" },
                new ContextIsNeeded_Question { QuestionId= 19,Caption = "Why does HTML think “chucknorris” is a color?", Url = "http://stackoverflow.com/questions/8318911/why-does-html-think-chucknorris-is-a-color" },
                new ContextIsNeeded_Question { QuestionId= 20,Caption = "Why are my balls disappearing?", Url = "http://stackoverflow.com/questions/11066050/why-are-my-balls-disappearing" },
                new ContextIsNeeded_Question { QuestionId= 21,Caption = "Why are my privates accessible?", Url = "http://stackoverflow.com/questions/5244997/why-are-my-privates-accessible" },
                new ContextIsNeeded_Question { QuestionId= 22,Caption = "Why are my listeners trigger happy", Url = "http://stackoverflow.com/questions/11309139/why-are-my-listeners-trigger-happy" },
                new ContextIsNeeded_Question { QuestionId= 23,Caption = "How can I kill a librarian without attracting more of them?", Url = "http://gaming.stackexchange.com/questions/182481/how-can-i-kill-a-librarian-without-attracting-more-of-them" },
                new ContextIsNeeded_Question { QuestionId = 24, Caption = "The Internet keeps me from dreaming?", Url = "http://gaming.stackexchange.com/questions/123060/the-internet-keeps-me-from-dreaming" },
                new ContextIsNeeded_Question { QuestionId = 42, Caption = "What items 'fit snugly in small areas'?", Url = "http://gaming.stackexchange.com/questions/121850/what-items-fit-snugly-in-small-areas" },
                new ContextIsNeeded_Question { QuestionId = 43, Caption = "Is it common to die at work?", Url = "http://gaming.stackexchange.com/questions/41503/is-it-common-to-die-at-work" },
                new ContextIsNeeded_Question { QuestionId = 44, Caption = "Can I detonate things without losing friends?", Url = "http://gaming.stackexchange.com/questions/17689/can-i-detonate-things-without-losing-friends" },
                new ContextIsNeeded_Question { QuestionId = 45, Caption = "Can I change my gender?", Url = "http://gaming.stackexchange.com/questions/125054/can-i-change-my-gender" },
                new ContextIsNeeded_Question { QuestionId = 46, Caption = "How can I make the animals wear pants?", Url = "http://gaming.stackexchange.com/questions/164862/how-can-i-make-the-animals-wear-pants" },
                new ContextIsNeeded_Question { QuestionId = 47, Caption = "Why is there a fly in my pants?", Url = "http://english.stackexchange.com/questions/46669/why-is-there-a-fly-in-my-pants" },
                new ContextIsNeeded_Question { QuestionId = 48, Caption = "How do I fatten someone up?", Url = "http://gaming.stackexchange.com/questions/177291/how-do-i-fatten-someone-up" },
                new ContextIsNeeded_Question { QuestionId = 49, Caption = "Should [waffles] be burninated?", Url = "http://meta.stackexchange.com/questions/234451/should-waffles-be-burninated" },
                new ContextIsNeeded_Question { QuestionId = 50, Caption = "Does there exist a singer's muzzle or silencer?", Url = "http://music.stackexchange.com/questions/23362/does-there-exist-a-singers-muzzle-or-silencer" },
                new ContextIsNeeded_Question { QuestionId = 51, Caption = "Why should I take showers?", Url = "http://gaming.stackexchange.com/questions/159672/why-should-i-take-showers" },
                new ContextIsNeeded_Question { QuestionId = 52, Caption = "'balls have dropped' what does it mean?", Url = "http://english.stackexchange.com/questions/195433/balls-have-dropped-what-does-it-mean" },
                new ContextIsNeeded_Question { QuestionId = 53, Caption = "How do I implement a physics gun?", Url="http://gamedev.stackexchange.com/questions/47628/how-do-i-implement-a-physics-gun" },
                new ContextIsNeeded_Question { QuestionId = 54, Caption = "How to handle walking into walls?", Url="http://gamedev.stackexchange.com/questions/23157/how-to-handle-walking-into-walls" },
                new ContextIsNeeded_Question { QuestionId = 55, Caption = "How to avoid being throttled?", Url = "http://gamedev.stackexchange.com/questions/56533/how-to-avoid-being-throttled" },
                new ContextIsNeeded_Question { QuestionId = 56, Caption = "How do I make time?", Url = "http://gamedev.stackexchange.com/questions/38295/how-do-i-make-time" },
                new ContextIsNeeded_Question { QuestionId = 57, Caption = "How can I kill Mom?", Url = "http://gaming.stackexchange.com/questions/31438/how-can-i-kill-mom" },
                new ContextIsNeeded_Question { QuestionId = 58, Caption = "Is there anyone left in the world, save me and my rifle?", Url = "http://gaming.stackexchange.com/questions/94983/is-there-anyone-left-in-the-world-save-me-and-my-rifle" },
                new ContextIsNeeded_Question { QuestionId = 59, Caption = "Is it bad if all my kittens starve?", Url = "http://gaming.stackexchange.com/questions/184326/is-it-bad-if-all-my-kittens-starve" },
                new ContextIsNeeded_Question { QuestionId = 60, Caption = "How can I prepare for getting hit by a bus?", Url = "http://workplace.stackexchange.com/questions/9128/how-can-i-prepare-for-getting-hit-by-a-bus" },
                new ContextIsNeeded_Question { QuestionId = 61, Caption = "How does happiness work?", Url = "http://gaming.stackexchange.com/questions/184385/how-does-happiness-work" },
                new ContextIsNeeded_Question { QuestionId = 62, Caption = "Whose underwear is this?", Url = "http://scifi.stackexchange.com/questions/68005/whose-underwear-is-this" },
                new ContextIsNeeded_Question { QuestionId = 63, Caption = "How can I turn into a cat?", Url = "http://gaming.stackexchange.com/questions/143469/how-can-i-turn-into-a-cat" },
                new ContextIsNeeded_Question { QuestionId = 64, Caption = "How do I make cats less proud?", Url = "http://gaming.stackexchange.com/questions/37573/how-do-i-make-cats-less-proud" },
                new ContextIsNeeded_Question { QuestionId = 65, Caption = "How to get over losing pennies all the time?", Url = "http://stackoverflow.com/questions/6915458/how-to-get-over-losing-pennies-all-the-time"},
                new ContextIsNeeded_Question { QuestionId = 66, Caption = "Is it possible to know the position of mom?", Url = "http://space.stackexchange.com/questions/4842/is-it-possible-to-know-the-position-of-mom" },
                new ContextIsNeeded_Question { QuestionId = 67, Caption = "Can you be afraid if you're dead?", Url = "http://rpg.stackexchange.com/questions/39510/can-you-be-afraid-if-youre-dead" },
                new ContextIsNeeded_Question { QuestionId = 68, Caption = "How do I Raise the Dead and Look Good Doing it?", Url = "http://rpg.stackexchange.com/questions/37309/how-do-i-raise-the-dead-and-look-good-doing-it" }
                );
        }

    }
}
