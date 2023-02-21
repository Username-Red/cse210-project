public class Square : Shape{
    // Attrbites 
    private double _sides;

    // Constructors
    public Square(double sides, string color) : base (color) {
        _sides = sides;
    }


    // Mehthods
    public override double GetArea()
    {
        return _sides * 2;
    }
}