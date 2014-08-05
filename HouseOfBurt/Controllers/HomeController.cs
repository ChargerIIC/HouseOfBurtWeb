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