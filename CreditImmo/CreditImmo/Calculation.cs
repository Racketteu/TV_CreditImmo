using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditImmo
{
    public class Calculation
    {
        public StringBuilder CalculateMonthlyPayment(CustomerInput customer)
        {
            decimal principal = customer.GetAmount();
            decimal interestRate = customer.GetNominalRate() / 100 / 12;
            int numberOfPayments = customer.GetDuration();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Month number;Monthly payment;Principal repaid;Interest paid;Principal remaining");

            decimal monthlyPayment = principal * interestRate / (1 - (decimal)Math.Pow(1 + (double)interestRate, -numberOfPayments));
            decimal principalRemaining = principal;

            for (int month = 1; month <= numberOfPayments; month++)
            {
                decimal interestMonth = principalRemaining * interestRate;
                decimal principalRepaidMonth = monthlyPayment - interestMonth;
                principalRemaining -= principalRepaidMonth;

                // Outputting details
                stringBuilder.AppendLine($"{month};{monthlyPayment:F2};{principalRepaidMonth:F2};{interestMonth:F2};{principalRemaining:F2}");
                Console.WriteLine($"Month {month}: Monthly payment = {monthlyPayment:F2}, Principal repaid = {principalRepaidMonth:F2} EUR, Interest paid = {interestMonth:F2} EUR, Principal remaining = {principalRemaining:F2} EUR");
            }

            return stringBuilder;
        }
    }
}
