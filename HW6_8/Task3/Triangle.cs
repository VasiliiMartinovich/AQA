namespace HW6_8.Task3;

public class Triangle : Figure
{
    public double _side1;
    public double _side2;
    public double _side3;
    public double _height;

    public Triangle(double side1, double side2, double side3, double height)
    {
        _side1 = side1;
        _side2 = side2;
        _side3 = side3;
        _height = height;
    }
    
    public override string Name => "Triangle";
    
    public override double Area()
    {
        return 0.5 * _side1 * _height;
    }

    public override double Perimeter()
    {
        return _side1 + _side2 + _side3;
    }
}