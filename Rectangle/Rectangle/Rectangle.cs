using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Rectangle
    {
        private int length;
        private int width;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public Rectangle(int side)
        {
            Create(side);
        }

        public int Perimeter()
        {
            return 2 * (length + width);
        }

        public int Area()
        {
            return length * width;
        }

        public Rectangle Create(int side)
        {
            return new Rectangle(side, side);
        }
    }
}
