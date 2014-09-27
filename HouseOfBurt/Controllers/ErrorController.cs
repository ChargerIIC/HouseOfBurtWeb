using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HouseOfBurt.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult E404()
        {
            HttpContext.Response.StatusCode = 404;
            ViewBag.ImageUrl = "../../Content/img/404.jpg";
            return View("Error");
        }

        public ActionResult E500()
        {
            HttpContext.Response.StatusCode = 500;
            ViewBag.ImageUrl = "../../Content/img/Error500.jpg";
            return View("Error");
        }
    }
}