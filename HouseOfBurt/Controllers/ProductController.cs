using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HouseOfBurt.Models;

namespace HouseOfBurt.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        [OutputCache(Duration = 86400)]
        public ActionResult Index()
        {
            var products = DataService.Instance.Database.Products;
            ViewBag.Products = products;
            ViewBag.Links = products.Select(x => x.SourceLink);
            return View();
        }

        public ActionResult Detail(int id = 1)
        {
            Product product = DataService.Instance.Database.Products.FirstOrDefault(x => x.ProductId == id);
            if (product == null) RedirectToAction("Index");

            ViewBag.Product = product;
            ViewBag.Links = product.SourceLink;
            return View();
        }

        [OutputCache(Duration = 86400)]
        public ActionResult License()
        {
            return View();
        }
    }
}