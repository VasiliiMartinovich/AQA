namespace Lesson_8.AbstractClass;

public class Circle : Shape
{
    public double Radius { get; set; }
    public override string Name { get; set; }
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}