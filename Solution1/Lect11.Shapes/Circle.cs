using System;
using System.Collections.Generic;
using System.Text;

namespace Lect11.Shapes
{
    class Circle : Shape
    {
        const double Pi = 3.14;
        public const string Name = "circle";
        int Radius { get; set; }
        double Area { get; set; }
        public override void CalculateArea()
        {
            base.CalculateArea();
            Area = Pi * Radius * Radius;
        }
    }
}
