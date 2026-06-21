namespace HW6_8.Task3;

public class Circle : Figure
{
    public double _radius;
    public override string Name => "Circle";

    public Circle(double radius)
    {
        _radius = radius;
    }
    public override double Area()
    {
        return Math.PI * _radius * _radius;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * _radius;
    }
}