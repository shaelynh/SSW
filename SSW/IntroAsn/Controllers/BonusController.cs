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
     * Intro Asn #3 Bonus Calculator
     **/
    public class BonusController : Controller
    {
        // GET: Bonus
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(BonusResponse resp)
        {
            //get sales amount from text box using the controller
            double salesAmt = resp.salesAmount;
            double bonusAmt = 0;

            //assign bonuses based on sales amount
            if (salesAmt <= 500)
            {
                bonusAmt = 0;
            }
            else if (salesAmt > 500 && salesAmt <= 2000)
            {
                bonusAmt = salesAmt * 0.02;
            }
            else if (salesAmt >= 2001 && salesAmt <= 5000)
            {
                bonusAmt = salesAmt * 0.03;
            }
            else if (salesAmt > 5000)
            {
                bonusAmt = salesAmt * 0.05;
            }
            //format to currency and set viewbag to display results
            ViewBag.amount = "With a Sales Amount of " + String.Format("{0:C2}", salesAmt);
            ViewBag.bonus = " your bonus would be: " + String.Format("{0:C2}",bonusAmt);
            return View();
        }
    }
}