using System.Dynamic;

using System.Runtime.InteropServices;

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius) : base()
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}