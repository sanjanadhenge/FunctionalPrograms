using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class QuotientAndReminder
    {
        public void QueAndRem(int Divisor ,int Dividend)
        {
            int Quotient = Dividend / Divisor;
            int Reminder = Dividend % Divisor;
            Console.WriteLine("Reminder =" + Reminder);
            Console.WriteLine("Quotient =" + Quotient);
        }
    }
}
