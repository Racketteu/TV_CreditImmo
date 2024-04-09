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

        public void CSVCreate(StringBuilder csvcontent)
        {
            System.IO.File.WriteAllText("debt.csv", csvcontent.ToString());
            Console.WriteLine("File created");
        }
    }
}
