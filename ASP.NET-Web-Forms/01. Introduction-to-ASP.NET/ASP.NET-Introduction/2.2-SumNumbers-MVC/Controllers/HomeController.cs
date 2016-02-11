using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2._2_SumNumbers_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult CalculateSum(FormCollection form)
        {
            decimal firstNumber = decimal.Parse(form["FirstNumber"].ToString());
            decimal secondNumber = decimal.Parse(form["SecondNumber"].ToString());

            ViewBag.Result = firstNumber + secondNumber;
            return View("Index");
        }
    }
}