using System;
using System.Collections.Generic;
using System.Text;

namespace Lect11.Shapes
{
    class Square : Shape
    {
        public const string Name = "square";
        int Side { get; set; }
        double Area { get; set; }
        public override void CalculateArea()
        {
            base.CalculateArea();
            Area = Side * Side;
        }
    }
}
