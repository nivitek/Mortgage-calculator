using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MortgageCalculator.Models
{
    public class Calculator
    {
        [Range(1000, 1000000)]
        [DisplayName("Principal ($1K - $1M)")]
        public int Principal { get; set; }

        [Range(1,30)]
        [DisplayName("Annual Interest Rate")]
        public float AnnualInterest { get; set; }

        [Range(1,30)]
        [DisplayName("Period in Years")]
        public byte Years { get; set; }


        [DisplayName("Loan Amount")]
        public string Total { get; set; }
        [DisplayName("Monthly Interest Rate")]
        public float MonthlyInterest { get; set; }
        [DisplayName("Tenure in Months")]
        public int Months { get; set; }
    }
}