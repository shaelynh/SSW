using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntroAsn.Models
{
    public class BonusResponse
    {
        //get sales amount from the textbox on the index
        [Required(ErrorMessage = "Sales Amount is required")]
        public double salesAmount { get; set; }

    }
}