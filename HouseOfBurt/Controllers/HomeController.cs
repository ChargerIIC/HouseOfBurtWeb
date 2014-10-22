using HouseOfBurt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HouseOfBurt.Utilities;

namespace HouseOfBurt.Controllers
{
    public class HomeController : Controller
    {
        [CompressFilter(Order = 1)]
        [OutputCache(Duration = 86400, Order = 2)]
        public ActionResult Index()
        {
            //Grab top five news items
            ViewBag.BigNewsItems = DataService.Instance.Database.Articles
                .OrderByDescending(n => n.CreationDate)
                .Take(4);

            ViewBag.Products = DataService.Instance.Database.Products
                .Take(4);

            return View();
        }

        [CompressFilter(Order = 1)]
        [OutputCache(Duration = 86400, Order = 2)]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [CompressFilter(Order = 1)]
        [OutputCache(Duration = 86400, Order = 2)]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

         [CompressFilter]
        public ActionResult Search(string search)
        {
            ViewBag.SearchTerm = search;

            if (search == null) return RedirectToAction("Index");

            var results = DataService.Instance.Database.Articles.Where(x => x.Slug.Contains(search));
            ViewBag.Results = results;
            return View();
        }

         [CompressFilter(Order = 1)]
         [OutputCache(Duration = 86400, Order = 2)]
         public ActionResult Resume()
        {
            return View();
        }
    }
}