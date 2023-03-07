using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Welcome to program");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select an option to execute the program 1. Filp Coin 2. Leap Year Check 3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1 :
                        Console.WriteLine("Enter the no of filps");
                        int n = Convert.ToInt32(Console.ReadLine());
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.Flip(n);
                        break;
                    case 2:
                        Console.WriteLine("Enter the year");
                        int Year = Convert.ToInt32(Console.ReadLine());
                        LeapYear leapYear = new LeapYear();
                        leapYear.LeapYearCheck(Year);
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}
