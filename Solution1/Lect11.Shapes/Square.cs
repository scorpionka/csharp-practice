namespace Lect11.Shapes
{
    public class Square : Shape
    {
        public int Side { get; set; }
        public Square(int side)
        {
            Name = "square";
            Side = side;
        }
        public override void CalculateArea()
        {
            base.CalculateArea();
            Area = Side * Side;
        }
    }
}