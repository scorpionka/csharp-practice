using System;

namespace Lect11.Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Circle(3);
            shapes[1] = new Square(4);
            shapes[2] = new Triangle(5, 6);
            foreach (var aShape in shapes)
            {
                Console.WriteLine("This is " + aShape.Name + ". CLR type is " + aShape.GetType() +
                ". Square is " + aShape.Area);
            }
        }
    }
}