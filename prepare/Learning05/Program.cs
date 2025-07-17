using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(30);
        square.SetColor("green");


        Circle circle = new Circle(0.5641895835);//approximate radius so that area = 1
        circle.SetColor("blue");

        Rectangle rect = new Rectangle(10, 20);
        rect.SetColor("red");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rect);

        foreach (Shape s in shapes)
        {
            DisplayShapeInfo(s);
        }

      
    }
    public static void DisplayShapeInfo(Shape shape)
    {
        Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}");
    }
}


