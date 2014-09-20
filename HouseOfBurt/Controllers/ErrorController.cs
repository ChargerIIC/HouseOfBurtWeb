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
            return View("Error");
        }
    }
}