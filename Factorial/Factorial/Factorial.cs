using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class Factorial
    {
        public static int Fact(int number)
        {
            int result = 1;
            if (number < 0)
            {
                throw new NegativeNumberFactorialException();
            }

            if(number == 2)
            {
                return 2;
            }
            return result;
        }
    }
}
