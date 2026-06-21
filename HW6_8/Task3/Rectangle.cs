namespace HW6_8.Task3;

public class Rectangle : Figure
{
    public double _width;
    public double _height;
    public override string Name => "Rectangle";
    
    public Rectangle(double width, double height)
    {
        _width =  width;
        _height = height;
    }

    public override double Area()
    {
        return  _width * _height;
    }

    public override double Perimeter()
    {
        return 2 * (_width + _height);
    }
}