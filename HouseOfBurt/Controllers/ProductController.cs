using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HouseOfBurt.Models;
using HouseOfBurt.Utilities;

namespace HouseOfBurt.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        [CompressFilter(Order = 1)]
        [OutputCache(Duration = 86400, Order = 2)]
        public ActionResult Index()
        {
            var products = DataService.Instance.Database.Products;
            ViewBag.Products = products;
            ViewBag.Links = products.Select(x => x.SourceLink);
            return View();
        }

        [CompressFilter]
        public ActionResult Detail(string id)
        {
            Product product = DataService.Instance.Database.Products.FirstOrDefault(x => x.Slug == id);
            if (product == null) return RedirectToAction("Index");

            ViewBag.Product = product;
            ViewBag.Links = product.SourceLink;
            return View();
        }

        [CompressFilter(Order = 1)]
        [OutputCache(Duration = 86400, Order = 2)]
        public ActionResult License()
        {
            return View();
        }
    }
}