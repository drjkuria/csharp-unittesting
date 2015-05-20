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

        [Test]
        public void TestFactorialOfZeroShouldBeOne()
        {
            Assert.That(Factorial.Fact(0), Is.EqualTo(1));
        }

        [Test]
        public void TestFactorialOfOneShouldBeOne()
        {
            Assert.That(Factorial.Fact(1), Is.EqualTo(1));
        }

        [Test]
        public void TestFactorialOfTwoShouldBeTwo()
        {
            Assert.That(Factorial.Fact(2), Is.EqualTo(2));
        }
    }
}
