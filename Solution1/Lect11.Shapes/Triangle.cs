using System;
using System.Collections.Generic;
using System.Text;

namespace Lect11.Shapes
{
    class Triangle : Shape
    {
        public const string Name = "triangle";
        int SideA { get; set; }
        int SideB { get; set; }
        double Area { get; set; }
        public override void CalculateArea()
        {
            base.CalculateArea();
            Area = (SideB * Math.Sqrt(SideA * SideA - (SideB * SideB) / 4)) / 2;
        }
    }
}
