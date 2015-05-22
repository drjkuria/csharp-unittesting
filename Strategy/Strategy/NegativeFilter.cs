using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class NegativeFilter
    {
        public static int NumbersCount(int count, int number)
        {
            if (number < 0)
            {
                count++;
            }
            return count;
        }
    }
}
