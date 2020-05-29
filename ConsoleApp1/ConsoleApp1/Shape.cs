using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Shape
    {
        protected double area;
        public abstract bool isShape();
        public abstract double calArea();
    }
}
