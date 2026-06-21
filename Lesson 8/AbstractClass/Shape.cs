namespace Lesson_8.AbstractClass;

public abstract class Shape
{
    public string Color { get; set; }
    public abstract string Name { get; set; }
    public abstract double GetArea();

    public void Draw()
    {
        Console.WriteLine("Shape Drawing");
    }
}