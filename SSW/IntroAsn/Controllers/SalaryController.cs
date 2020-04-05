using IntroAsn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroAsn.Controllers
{
    /**
     * 09/29/19
     * Shaelyn Hooley
     * Intro Asn #2 Next Year Salary Predictor
     **/
    public class SalaryController : Controller
    {
        // GET: Salary
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(SalaryResponse resp)
        {
            //get values from textboxes using response
            string fName = resp.firstName;
            string lName = resp.lastName;
            double currSalary = resp.currentSalary;

            double nextSalary = 0;
            double bonus = 0;
            double over;

            //assign proper bonus to calculate next years salary
            if (currSalary < 40000)
            {
                bonus = currSalary * 0.05;
                nextSalary = currSalary + bonus;
            }
            else if (currSalary >= 40000)
            {
                over = currSalary - 40000;
                bonus = (over * 0.02) + 2000;
                nextSalary = currSalary + bonus;
            }

            //format to currency and add result to view bag to display on the index
            ViewBag.nextYear = "Next Year's Salary for " + fName + " " + lName + " should be : " + String.Format("{0:C2}", nextSalary);

            return View();
        }
    }
}