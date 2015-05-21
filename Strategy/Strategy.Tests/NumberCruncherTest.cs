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

    }
}
