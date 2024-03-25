using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditImmo
{
    public class Calculation
    {
        public double CalculateMonthlyPayment(CustomerInput customer)
        {
            double principal = customer.GetAmount();
            double interestRate = customer.GetNominalRate() / 100 / 12;
            int numberOfPayments = customer.GetDuration();

            double monthlyPayment = principal * interestRate * Math.Pow(1 + interestRate, numberOfPayments)
                                    / (Math.Pow(1 + interestRate, numberOfPayments) - 1);

            return Math.Round(monthlyPayment, 2);
        }
    }
}
