using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HouseOfBurt.Models;

namespace HouseOfBurt.Controllers
{
    public class ApplicationController : Controller
    {
        #region Class Level Variables

        private ContextIsNeeded_Question[] questions = DataService.Instance.Database.ContextIsNeededQuestions.ToArray();

        List<Tuple<string, int, int>> images = new List<Tuple<string, int, int>>
            {
                new Tuple<string, int, int>("../Content/img/BuisnessSuitWonder.png",20,65),
                new Tuple<string, int, int>("../Content/img/ComputerAsk.png", 20,65),
                new Tuple<string, int, int>("../Content/img/LaptopWonder.png", 20,70),
                new Tuple<string, int, int>("../Content/img/KidWonder.png", 20,65),
                new Tuple<string, int, int>("../Content/img/LadyWonder.png", 30,55)
            };

        #endregion Class Level Variables

        // GET: Application
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContextIsNeeded()
        {
            var random = new Random();
            var image = images[random.Next(images.Count)];
            ViewBag.Question = questions[random.Next(questions.Length)];
            ViewBag.Image = image.Item1;
            ViewBag.QuestionTop = image.Item2;
            ViewBag.QuestionLeft = image.Item3;
            return View();
        }

        public JsonResult ContextNeededEndpoint()
        {
            var json = new JsonResult();
            var random = new Random();
            var image = images[random.Next(images.Count)];
            var question = questions[random.Next(questions.Length)];

            json.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            json.Data = new
            {
                url = image.Item1,
                top = image.Item2,
                left = image.Item3,
                caption = question.Caption,
                link = question.Url
            };

            return json;
        }
    }
}