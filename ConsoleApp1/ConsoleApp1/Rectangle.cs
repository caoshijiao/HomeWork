using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Rectangle : Shape
    {
        private double height;
        private double wide;
        public Rectangle(double height, double wide)
        {
            this.wide = wide;
            this.height = height;
        }
        public override double calArea()
        {
            if (isShape())
            {
                this.area = height * wide;
                return area;
            }
            else
            {
                return 0;
            }


        }

        public override bool isShape()
        {
            if (height > 0 && wide > 0)
                return true;
            else
                return false;
        }
    }
}
