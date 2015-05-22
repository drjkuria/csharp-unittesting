using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class EvenFilter: Filter
    {
        public int NumbersCount(int count, int number)
        {
            if (number % 2 == 0)
            {
                count++;
            }
            return count;
        }
    }
}
