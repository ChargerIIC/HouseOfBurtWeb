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
        // GET: Application
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContextIsNeeded()
        {
            var questions = DataService.Instance.Database.ContextIsNeededQuestions.ToArray();

            var images = new List<Tuple<string, int, int>>
            {
                new Tuple<string, int, int>("../Content/img/BuisnessSuitWonder.png",20,65),
                new Tuple<string, int, int>("../Content/img/ComputerAsk.png", 20,65),
                new Tuple<string, int, int>("../Content/img/LaptopWonder.png", 20,70),
                new Tuple<string, int, int>("../Content/img/KidWonder.png", 20,65),
                new Tuple<string, int, int>("../Content/img/LadyWonder.png", 30,55)
            };

            var random = new Random();
            var image = images[random.Next(images.Count)];
            ViewBag.Question = questions[random.Next(questions.Length)];
            ViewBag.Image = image.Item1;
            ViewBag.QuestionTop = image.Item2;
            ViewBag.QuestionLeft = image.Item3;
            return View();
        }
    }
}