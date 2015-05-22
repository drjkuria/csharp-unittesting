using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class PositiveFilter: Filter
    {
        public int NumbersCount(int count, int number)
        {
            if (number >= 0)
            {
                count++;
            }
            return count;
        }
    }
}
