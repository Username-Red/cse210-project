public class Circle : Shape {
    // Attributes
    private double _radius;

    // Constrctors
    public Circle(double radius, string color) : base (color) {
        _radius = radius;

    }

    // Methods
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }

}