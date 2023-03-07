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
                Console.WriteLine("Select an option to execute the program 1. Filp Coin 2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1 :
                        Console.WriteLine("Enter the no of filps");
                        int n = Convert.ToInt32(Console.ReadLine());
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.Flip(n);
                        break;
                    case 2 :
                        flag = false;
                        break;
                }
            }
        }
    }
}
