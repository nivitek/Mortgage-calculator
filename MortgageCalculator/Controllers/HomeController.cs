using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MortgageCalculator.Models;

namespace MortgageCalculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var amount = new Calculator();
            return View(amount);
        }
        [HttpPost]
        public ActionResult Index(Calculator calculator)
        {
            if(calculator == null)
            {
                return RedirectToAction("Error");
            }
            int percent = 100; int months_in_year = 12;
            calculator.MonthlyInterest = calculator.AnnualInterest / percent * months_in_year;
            calculator.Months = calculator.Years * months_in_year;
            double mortgage = calculator.Principal *
                ((calculator.MonthlyInterest * (Math.Pow(1 + calculator.MonthlyInterest, calculator.Months)))
                / (Math.Pow(1 + calculator.MonthlyInterest, calculator.Months) - 1));
            calculator.Total = mortgage.ToString("C0");
            return View(calculator);
        }
        [HandleError] public ActionResult Error() { return View(); }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}