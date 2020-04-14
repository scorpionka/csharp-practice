namespace Lect11.Shapes
{
    public class Circle : Shape
    {
        public const double Pi = 3.1415;
        public int Radius { get; set; }
        public Circle(int radius)
        {
            Name = "circle";
            Radius = radius;
        }
        public override void CalculateArea()
        {
            base.CalculateArea();
            Area = Pi * Radius * Radius;
        }
    }
}