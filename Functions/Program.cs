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
                Console.WriteLine("Select an option to execute the program 1. Filp Coin 2. Leap Year Check 3. Power of 2 4.Harmonic Number 5.Prime Factors 6.To Calculate Quotient and Reminder 7. Swapping Of two No 8.Even And Odd 9.Check Alphabet 10.Greatest Among three 11.Exit");
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
                        Console.WriteLine("Enter the Power number");
                        int N = Convert.ToInt32(Console.ReadLine());
                        PowerOf2 powerOf2 = new PowerOf2();
                        powerOf2.CalculatePower(N);
                        break;
                    case 4:
                        Console.WriteLine("Enter the Nth number");
                        int H = Convert.ToInt32(Console.ReadLine());
                        HarmonicNumber harmonicNumber = new HarmonicNumber();
                        harmonicNumber.CalculateHarmonicValue(H);
                        break;
                    case 5:
                        Console.WriteLine("Enter the number");
                        int P = Convert.ToInt32(Console.ReadLine());
                        PrimeFactor primeFactor = new PrimeFactor();
                        primeFactor.PrimeFactorization(P);
                        break;
                    case 6:
                        Console.WriteLine("Enter the Dividend");
                        int Dividend = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Divisor");
                        int Divisor = Convert.ToInt32(Console.ReadLine());
                        QuotientAndReminder quotientAndReminder = new QuotientAndReminder();
                        quotientAndReminder.QueAndRem(Divisor, Dividend);
                        break;
                    case 7:
                        Console.WriteLine("Enter the Number1");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Number2");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Swap swap = new Swap();
                        swap.SwapOfTwo(a, b);   
                        break;
                    case 8:
                        Console.WriteLine("Enter the Nth number");
                        int Value = Convert.ToInt32(Console.ReadLine());
                        EvenOdd evenOdd = new EvenOdd();
                        evenOdd.CheckEvenOrOdd(Value);
                        break;
                    case 9:
                         Console.WriteLine("Enter the Albhabet");
                         char A = Convert.ToChar(Console.ReadLine());
                         CheckAlphabet checkAlphabet = new CheckAlphabet();
                         checkAlphabet.Check(A);
                         break;
                    case 10:
                        Console.WriteLine("Enter the Number1");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Number2");
                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Number2");
                        int z = Convert.ToInt32(Console.ReadLine());
                        GreatestAmongThree  greatestAmongThree = new GreatestAmongThree();
                        greatestAmongThree.FindGreatest(x, y, z);
                        break;
                    case 11:
                        flag = false;
                        break;
                }
            }
        }
    }
}
