using System;

namespace Lect11.Shapes
{
    public class Triangle : Shape
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public Triangle(int sideA, int sideB)
        {
            Name = "triangle";
            SideA = sideA;
            SideB = sideB;
        }
        public override void CalculateArea()
        {
            base.CalculateArea();
            Area = (SideB * Math.Sqrt(SideA * SideA - (SideB * SideB) / 4)) / 2;
        }
    }
}