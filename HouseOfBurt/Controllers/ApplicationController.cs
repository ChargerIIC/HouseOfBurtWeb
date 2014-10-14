using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using HouseOfBurt.Models;
using HouseOfBurt.Services;

namespace HouseOfBurt.Controllers
{
    public class ApplicationController : Controller
    {
        #region Class Level Variables

        private ContextIsNeeded_Question[] questions = DataService.Instance.Database.ContextIsNeededQuestions.ToArray();

        List<Tuple<string, int, int>> images = new List<Tuple<string, int, int>>
            {
                new Tuple<string, int, int>("../Content/img/BuisnessSuitWonder.jpg",20,65),
                new Tuple<string, int, int>("../Content/img/ComputerAsk.jpg", 20,65),
                new Tuple<string, int, int>("../Content/img/LaptopWonder.jpg", 20,70),
                new Tuple<string, int, int>("../Content/img/KidWonder.jpg", 20,65),
                new Tuple<string, int, int>("../Content/img/LadyWonder.jpg", 30,55)
            };

        private EmailService emailService;
        private EmailService EmailSvc
        {
            get { return emailService ?? (emailService = new EmailService()); }
        }

        #endregion Class Level Variables

        // GET: Application
        public ActionResult Index()
        {
            ViewBag.WebApplications = DataService.Instance.Database.WebApplications.ToList();
            return View();
        }

        public ActionResult FresnoPopulationMap()
        {
            return View();
        }

        public ActionResult ContextIsNeeded()
        {
            return View();
        }

        [HttpPost]
        public JsonResult ContextSubmission(object[] link)
        {
            Uri url;
            bool result = Uri.TryCreate(link[0].ToString(), UriKind.Absolute, out url) && url.Scheme == Uri.UriSchemeHttp;

            if (result)
            {
                EmailSvc.SendSelfEmail("ContextIsNeeded Submission", url.ToString());

                return new JsonResult() {Data = "sucess"};
            }

            return new JsonResult() { Data = "failure"};
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