using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FutureInvestmentCalculator.Models
{
    public class FutureValueModel
    {
        [Required(ErrorMessage = "please enter a monthly investment")]
        [Range(1,500,ErrorMessage ="Monthly must been between 1 to 500")]
        public decimal? MonthlyInvestment { get; set; }

        [Required(ErrorMessage = "please enter a Yearky interest rate")]
        [Range(0.1, 10.0, ErrorMessage = "Interest Rate Range must be between 0.1 to 10")]
        public decimal? YearlyInterestRate { get; set; }

        [Required(ErrorMessage = "please enter number of years")]
        [Range(1, 50, ErrorMessage = "Number of years must been between 1 to 50")]
        public int? Years { get; set; }

        public decimal Calculate()
        {
            int months = Years.Value * 12;
            decimal monthlyInterestRate = YearlyInterestRate.Value / 12 / 100;
            decimal futureValue = 0;

            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment.Value) * (1 + monthlyInterestRate);
            }

            return futureValue;
        }
    }
}
