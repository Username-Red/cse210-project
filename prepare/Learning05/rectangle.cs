public class Rectangle : Shape {
    // Attributes
    private double _length;
    private double _width;

    // Constructors
    public Rectangle(double length, double width, string color) : base (color) {
            _width = width;
            _length = length;
        }

    // Methods
    public override double GetArea()
    {
        return _length * _width;
    }
}