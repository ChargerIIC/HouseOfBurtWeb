using HouseOfBurt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HouseOfBurt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Grab top five news items
            ViewBag.BigNewsItems = DataService.Instance.Database.Articles
                .OrderBy(n => n.CreationDate)
                .Take(4);

            foreach(Article a in ViewBag.BigNewsItems)
                a.Content = a.Content.TruncateHtml(150);

            ViewBag.LittleNewsItems = DataService.Instance.Database.Articles
                .OrderBy(n => n.CreationDate)
                .Skip(4)
                .Take(4);

            foreach (Article a in ViewBag.LittleNewsItems)
                a.Content = a.Content.TruncateHtml(150);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Search(string search)
        {
            ViewBag.SearchTerm = search;

            if (search == null) return RedirectToAction("Index");

            var context = new DataContextContainer();
            ViewBag.Results = context.Articles.Where(x => x.Title.Contains(search));

            return View();
        }
    }
}