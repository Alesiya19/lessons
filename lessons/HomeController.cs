using _5456.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace _5456.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var weeks = new List<Day>();
            var mondey = new Day();
            var tuesday = new Day();

            mondey.Name = "Понедельник";
            mondey.Lessons = new Lesson[2];
            mondey.Lessons[0] = new Lesson() { Hour = 8, Minute = 45, Lesson1 = "Дискретка"};
            mondey.Lessons[1] = new Lesson() { Hour = 5, Minute = 47, Lesson1 = "Матанализ"};
            Array.Sort(mondey.Lessons);
            weeks.Add(mondey);

            tuesday.Name = "Вторник";
            tuesday.Lessons = new Lesson[2];
            tuesday.Lessons[0] = new Lesson() { Hour = 4, Minute = 14, Lesson1 = "АВС" };
            tuesday.Lessons[1] = new Lesson() { Hour = 4, Minute = 7, Lesson1 = "Физра" };
            Array.Sort(tuesday.Lessons);
            weeks.Add(tuesday);

            return View(weeks);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}