using System;

namespace Shapes
{
    public class StartUp
    {
        public static void Main()
        {
            Circle circle = new Circle(5);

            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.CalculateArea());
        }
    }
}