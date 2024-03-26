using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditImmo
{
    public class CSV
    {
        public CSV() { }
        public string CSVMake(CustomerInput customerInput)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Calculation calculation = new Calculation();
            double monthlypayment = calculation.CalculateMonthlyPayment(customerInput);

            double debt = monthlypayment*customerInput.GetDuration();
            double debtrefund = 0;

            stringBuilder.AppendLine($"Number; Monthly payment; Capital remaining; Capital repaid");
            for (int i = 0; i < customerInput.GetDuration(); i++)
            {
                stringBuilder.AppendLine($"{i + 1};{monthlypayment};{debt};{debtrefund}");
                debt -= monthlypayment;
                debtrefund += monthlypayment;
            }
            return stringBuilder.ToString();
        }

        public void CSVCreate(string csvcontent)
        {
            System.IO.File.WriteAllText("debt.csv", csvcontent);
            Console.WriteLine("File created");
        }
    }
}
