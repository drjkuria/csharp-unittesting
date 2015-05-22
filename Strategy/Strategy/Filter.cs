using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface Filter
    {
        int NumbersCount(int count, int number);
    }
}
