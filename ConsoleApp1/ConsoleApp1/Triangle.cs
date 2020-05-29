using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Triangle : Shape
    {
        private double length1;
        private double length2;
        private double length3;
        public Triangle(double length1, double length2, double length3)
        {
            this.length1 = length1;
            this.length2 = length2;
            this.length3 = length3;
        }
        public override double calArea()
        {
            if (isShape())
            {
                double p = (length1 + length2 + length3) / 2;
                area = Math.Sqrt(p * (p - length1) * (p - length2) * (p - length3));
                return area;
            }
            else
            {
                return 0;
            }

        }

        public override bool isShape()
        {
            if (length1 + length2 > length3 && length1 + length3 > length2 && length2 + length3 > length1)
                return true;
            else
                return false;
        }
    }
}
