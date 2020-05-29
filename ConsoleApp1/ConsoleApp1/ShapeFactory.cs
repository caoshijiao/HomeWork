using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ShapeFactory
    {
        Random ran = new Random();
        public Shape createShape(String shapeType)
        {

            if (shapeType == null)
            {
                return null;
            }
            shapeType = shapeType.ToUpper();
            switch (shapeType)
            {
                case "RECTANGLE":
                    Console.WriteLine("长方形");
                    return new Rectangle(ran.NextDouble()+ran.Next(0,99), ran.NextDouble() + ran.Next(0, 99));
                case "SQUARE":
                    Console.WriteLine("正方形");
                    return new Square(ran.NextDouble() + ran.Next(0, 99));
                case "TRIANGLE":
                    Console.WriteLine("三角形");
                    return new Triangle(ran.NextDouble() + ran.Next(0, 99), ran.NextDouble() + ran.Next(0, 99),
                        ran.NextDouble() + ran.Next(0, 99));
                default:
                    return null;
            }
        }
    }
}
