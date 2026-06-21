namespace Lesson_8.Interfaces;

public class Bird : IFlyable
{
    public int MaxAltitude { get; set; }
    public void Fly()
    {
        Console.WriteLine("Bird is flying");
    }
}