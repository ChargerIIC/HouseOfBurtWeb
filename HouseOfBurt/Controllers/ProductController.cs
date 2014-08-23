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
            return View();
        }

        public ActionResult Product(int id)
        {
            ViewBag.Product = DataService.Instance.Database.Products.FirstOrDefault(p => p.ProductId == id);
            return View();
        }
    }
}