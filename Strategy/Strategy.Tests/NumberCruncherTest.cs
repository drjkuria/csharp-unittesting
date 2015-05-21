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
            int positives = new NumberCruncher(-5, -4, -3, -2, -1, 0, 1, 2, 3, 4).CountPositive();
            Assert.AreEqual(5, positives);
        }

        [Test]
        public void TestCountNegative()
        {
            int negatives = new NumberCruncher(-5, -4, -3, -2, -1, 0, 1, 2, 3, 4).CountNegative();
            Assert.AreEqual(5, negatives);
        }

        [Test]
        public void TestCountEven()
        {
            int evens = new NumberCruncher(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11).CountEven();
            Assert.AreEqual(5, evens);
        }

        [Test]
        public void TestCountOdd()
        {
            int odds = new NumberCruncher(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11).CountOdd();
            Assert.AreEqual(6, odds);
        }

    }
}
