using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class Swap
    {
        public void SwapOfTwo(int a ,int b)
        {
            int temp = 0;
            temp = a;
            a= b;
            b= temp;
            Console.WriteLine("After Swapping Numbers are {0},{1} ",a,b);
        }
    }
}
