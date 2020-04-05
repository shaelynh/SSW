using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntroAsn.Models
{
    public class CreditResponse
    {
        //get values from textboxes
        [Required(ErrorMessage = "Old Balance is required")]
        public double oldBalance { get; set; }

        [Required(ErrorMessage = "Charges are required")]
        public double charges { get; set; }

        [Required(ErrorMessage = "Credits are required")]
        public double credits { get; set; }
    }
}