namespace Lesson_8.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Bird bird = new Bird();
        AirPlane plane = new AirPlane();
        
        MakeFlight(bird);
        MakeFlight(plane);

    }

    static void MakeFlight(IFlyable flyable)
    {
        flyable.Fly();
    }
}