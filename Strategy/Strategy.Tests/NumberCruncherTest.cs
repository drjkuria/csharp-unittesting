using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy;
using NUnit.Framework;

namespace Strategy.Tests
{
    [TestFixture]
    public class NumberCruncherTest
    {
        [Test]
        public void TestCountPositive()
        {
            int positives = new NumberCruncher(new PositiveFilter(), -5, -4, -3, -2, -1, 0, 1, 2, 3, 4).CountPositive();
            Assert.AreEqual(5, positives);
        }

        [Test]
        public void TestCountNegative()
        {
            int negatives = new NumberCruncher(new NegativeFilter(), -5, -4, -3, -2, -1, 0, 1, 2, 3, 4).CountNegative();
            Assert.AreEqual(5, negatives);
        }

        [Test]
        public void TestCountEven()
        {
            int evens = new NumberCruncher(new EvenFilter(), 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11).CountEven();
            Assert.AreEqual(5, evens);
        }

        [Test]
        public void TestCountOdd()
        {
            int odds = new NumberCruncher(new OddFilter(), 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11).CountOdd();
            Assert.AreEqual(6, odds);
        }

    }
}
