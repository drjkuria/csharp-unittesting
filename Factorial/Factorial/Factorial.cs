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
            if (number < 0)
            {
                throw new NegativeNumberFactorialException();
            }
            return 0;
        }
    }
}
