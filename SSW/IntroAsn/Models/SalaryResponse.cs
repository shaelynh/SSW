using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntroAsn.Models
{
    public class SalaryResponse
    {
        //get all values from textboxes from index
        [Required(ErrorMessage = "First Name is required")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Current Salary is required")]
        public double currentSalary { get; set; }
    }
}