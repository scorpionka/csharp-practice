namespace Lect11.Shapes
{
    public class Shape
    {
        public string Name { get; set; }
        private double _area;
        public double Area
        {
            get
            {
                CalculateArea();
                return _area;
            }
            set
            {
                _area = value;
            }
        }
        public virtual void CalculateArea()
        {
        }
    }
}