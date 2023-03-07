using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class CheckAlphabet
    {
        public void Check(char A)
        {
            if (A ==  'a' || A == 'e'||A == 'i'||A == 'o'||A == 'u'||A == 'A'||A == 'E'||A == 'I'||A == 'O'||A == 'U')
            {
                Console.WriteLine("{0} is Vowel", A);
            }
            else
            {
                Console.WriteLine("{0} is Consonant", A);
            }
        }
    }
}
