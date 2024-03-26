using System;
using System.Text;

namespace CreditImmo 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int duration = 0;
            double amount = 0;
            double nominalRate = 0;
            try
            {
                duration = int.Parse(args[0]);
                amount = double.Parse(args[1]);
                nominalRate = double.Parse(args[2]);
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
            string csvcontent = csv.CSVMake(customerInput);
            csv.CSVCreate(csvcontent);
        }
    }
}