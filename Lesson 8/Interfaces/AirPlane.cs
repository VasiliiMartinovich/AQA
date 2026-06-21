namespace Lesson_8.Interfaces;

public class AirPlane : IFlyable
{
    public int MaxAltitude { get; set; }
    public void Fly()
    {
        Console.WriteLine("AirPlane is flying");
    }
}