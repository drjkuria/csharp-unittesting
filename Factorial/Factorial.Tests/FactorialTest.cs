using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factorial;
using NUnit.Framework;

namespace Factorial.Tests
{
    [TestFixture]
    public class FactorialTest
    {
        [Test]
        [ExpectedException(typeof(NegativeNumberFactorialException))]
        public void TestFactorialOfANegativeNumber()
        {
            Factorial.Fact(-2);
        }
    }
}
