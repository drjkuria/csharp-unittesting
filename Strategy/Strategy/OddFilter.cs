using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class OddFilter: Filter
    {
        public int NumbersCount(int count, int number)
        {
            if (number % 2 == 1)
            {
                count++;
            }
            return count;
        }
    }
}
