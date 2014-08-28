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
        public ActionResult Index()
        {
            ViewBag.Products = DataService.Instance.Database.Products;
            return View();
        }

        public ActionResult Detail(int id = 1)
        {

            Product product = DataService.Instance.Database.Products.FirstOrDefault(x => x.ProductId == id);

            ViewBag.Product = product;
            return View();
        }

        public ActionResult License()
        {
            return View();
        }
    }
}