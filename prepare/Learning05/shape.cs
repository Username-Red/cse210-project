public class Shape {
    // Attributes
    private string _color = "NoCol";

    // Constructors
    public Shape(string color) {
        _color = color;
    }

    // Methods
    public string GetColor() {
        return _color;
    }
    public void SetColor(string color) {
        _color = color;
    }

    public virtual double GetArea() {
        double area = 80085;
        return area;
    }
}