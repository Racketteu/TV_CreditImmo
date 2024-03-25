using CreditImmo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnitaireCreditImmo
{
    public class TestCalculation
    {
        [Theory]
        [InlineData(108, 50000, 1, 484.30)]
        [InlineData(300, 100000, 10, 908.70)]
        public void CalculateMonthlyPayment_Test(int duration, double amount, double nominalRate, double result)
        {
            CustomerInput customerInput = new CustomerInput(duration, amount, nominalRate);
            Calculation calculation = new Calculation();
            double monthlyPayment = calculation.CalculateMonthlyPayment(customerInput);
            Assert.Equal(result, monthlyPayment);
        }
    }
}
