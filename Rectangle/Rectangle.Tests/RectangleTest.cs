using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle;
using NUnit.Framework;

namespace Rectangle.Tests
{
    [TestFixture]
    public class RectangleTest
    {
        [Test]
        public void TestPerimeter()
        {
            Rectangle rectangle = new Rectangle(5, 4);
            Assert.AreEqual(18, rectangle.Perimeter());
        }

        [Test]
        public void TestArea()
        {
            Rectangle rectangle = new Rectangle(5, 4);
            Assert.AreEqual(20, rectangle.Area());
        }

        [Test]
        public void TestSquare()
        {
            Rectangle square = new Rectangle(5);
            Assert.AreEqual(square.Length, square.Width);
        }
    }
}
