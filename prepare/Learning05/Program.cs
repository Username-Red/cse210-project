using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();


        Square square = new Square(20, "Blue");
        shapes.Add(square);

        Rectangle rectangle = new Rectangle(10, 20, "Red");
        shapes.Add(rectangle);

        Circle circle = new Circle(30, "Yellow");
        shapes.Add(circle);

        foreach (Shape shape in shapes) {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());

        }

        



    }
}