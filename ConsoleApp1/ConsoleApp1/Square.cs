using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Square : Shape
    {
        private double length;
        public Square(double length)
        {
            this.length = length;
        }
        public override double calArea()
        {
            if (isShape())
            {
                this.area = length * length;
                return area;
            }
            else
            {
                return 0;
            }

        }

        public override bool isShape()
        {
            if (length > 0)
                return true;
            else
                return false;

        }
    }
}
