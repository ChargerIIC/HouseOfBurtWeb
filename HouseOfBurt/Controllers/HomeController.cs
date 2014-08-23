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
                .OrderByDescending(n => n.CreationDate)
                .Take(4);

            ViewBag.Products = DataService.Instance.Database.Products
                .Take(3);

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

            ViewBag.Results = DataService.Instance.Database.Articles.Where(x => x.Title.Contains(search));

            return View();
        }

        public ActionResult Resume()
        {
            return View();
        }
    }
}