using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();

        Circle circle1 = new Circle("black", 3.56);
        shapes.Add(circle1);

        Circle circle2 = new Circle("pink", 2.56);
        shapes.Add(circle2);
        
        Rectangle rectangle = new Rectangle("gray", 1.34, 2.78);
        shapes.Add(rectangle);

        Square square = new Square("green", 1.34);
        shapes.Add(square);
        
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"{color} area is: {area}");
        }

    }
}