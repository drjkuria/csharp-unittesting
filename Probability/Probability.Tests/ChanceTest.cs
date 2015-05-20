using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Probability;
using NUnit.Framework;

namespace Probability.Tests
{
    [TestFixture]
    public class ChanceTest
    {
        [Test]
        public void TestForCompliment()
        {
            Chance thirtyPercentChance = new Chance(new decimal(0.3));
            Assert.AreEqual(new Chance(new decimal(0.7)), thirtyPercentChance.Not());
        }

        [Test]
        public void TestForAnd()
        {
            Chance thirtyPercentChance = new Chance(new decimal(0.3));
            Chance twentyPercentChance = new Chance(new decimal(0.2));
            Assert.AreEqual(new Chance(new decimal(0.06)), thirtyPercentChance.And(twentyPercentChance));
        }

    }
}
