
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] shapeType = new string[3] { "RECTANGLE", "SQUARE", "TRIANGLE" };
            ShapeFactory shapeFactory = new ShapeFactory();
            Console.WriteLine("随机生成形状：");
            Random ran = new Random();
            Shape aShape=shapeFactory.createShape(shapeType[ran.Next(0, 3)]);
            Console.WriteLine($"area={aShape.calArea()}");

        }
    }
}
