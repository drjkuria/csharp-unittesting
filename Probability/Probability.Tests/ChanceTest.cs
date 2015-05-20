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
        private Chance thirtyPercentChance;
        private Chance twentyPercentChance;
        [SetUp]
        public void SetUp()
        {
            thirtyPercentChance = new Chance(new decimal(0.3));
            twentyPercentChance = new Chance(new decimal(0.2));
        }
        [Test]
        public void TestForCompliment()
        {
            Assert.AreEqual(new Chance(new decimal(0.7)), thirtyPercentChance.Not());
        }

        [Test]
        public void TestForAnd()
        {
            Assert.AreEqual(new Chance(new decimal(0.06)), thirtyPercentChance.And(twentyPercentChance));
        }

        [Test]
        public void TestForOr()
        {
            Assert.AreEqual(new Chance(new decimal(0.44)), thirtyPercentChance.Or(twentyPercentChance));
        }

    }
}
