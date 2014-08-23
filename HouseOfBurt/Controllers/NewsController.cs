﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HouseOfBurt.Models;

namespace HouseOfBurt.Controllers
{
    public class NewsController : Controller
    {

        // GET: News
        public ActionResult Index()
        {
            ViewBag.NewsItems = DataService.Instance.Database.Articles.Take(10);
            ViewBag.Header = "News Items";
            return View();
        }

        public ActionResult Category(string category)
        {
            Category filter = DataService.Instance.Database.Categories.FirstOrDefault(x => x.Caption == category);

            ViewBag.Header = Char.ToUpper(category[0]) + category.Substring(1) + " News:";
            var articles = DataService.Instance.Database.Articles.ToList();
            var newsItems = articles.Where(n => n.Tags.Contains(filter));
            if (!newsItems.Any()) newsItems = DataService.Instance.Database.Articles.ToList();
            ViewBag.NewsItems = newsItems;
            return View("Index");
        }
    }
}