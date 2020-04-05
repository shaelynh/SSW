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
     * Intro Asn #1 Credit Card Payment Calculator
     **/
    public class CreditController : Controller
    {
        // GET: Credit
        [HttpGet]
        public ActionResult Index()
        {
         
            return View();
        }
        [HttpPost]
        public ActionResult Index(CreditResponse resp)
        {
            //get values from text box using credit response
            double oldB = resp.oldBalance;
            double c = resp.charges;
            double cr = resp.credits;

            //apply approp. charges and update balances
            double financeCharges = oldB * 0.015;
            double newBalance = oldB + c + financeCharges - cr;
            double minPayment;

            if (newBalance <= 20)
            {
                minPayment = newBalance;
            }
            else
            {
                minPayment = (newBalance * 0.10) + 20;
            }
            //format to currency and set view bag for display
            ViewBag.financeBag = String.Format("{0:C2}",financeCharges);
            ViewBag.balanceBag = String.Format("{0:C2}",newBalance);
            ViewBag.minBag = String.Format("{0:C2}",minPayment);

            return View();
        }
    }
}