namespace Lesson_8;

public class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public new void MakeSound()
    {
        Console.WriteLine("Meow-meow");
    }

    public override void MakeSound2()
    {
        Console.WriteLine("Meow-meow 2");
    }
}