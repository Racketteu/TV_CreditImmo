using System;
using System.Text;

namespace CreditImmo 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int duration = 0;
            decimal amount = 0;
            decimal nominalRate = 0;
            try
            {
                duration = int.Parse(args[0]);
                amount = decimal.Parse(args[1]);
                nominalRate = decimal.Parse(args[2]);
            }
            catch {
                Console.WriteLine("Erreur de saisie");
                return;
            }
            CustomerInput customerInput = new CustomerInput(duration, amount,nominalRate);
            if (!customerInput.CheckDuraction() || !customerInput.CheckNominalRate() || !customerInput.CheckAmount())
            {
                Console.WriteLine("Les saisies ne respectent pas les régles !");
                return;
            }
            CSV csv = new CSV();
            Calculation calculation = new Calculation();
            var stringbuilder = calculation.CalculateMonthlyPayment(customerInput);
            csv.CSVCreate(stringbuilder);
        }
    }
}