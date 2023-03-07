using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class LeapYear
    {
        public void LeapYearCheck(int Year)
        {
            if((Year % 4 == 0) && (Year % 100 != 0) || (Year % 400 == 0))
             {
                Console.WriteLine("{0} is Leap year",Year);
             }
            else
            {
                Console.WriteLine("{0} is not Leap year",Year);
            }

                   
        }
    }
}
