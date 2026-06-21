namespace Lesson_8;

public class Animal
{
    public Animal(string name)
    {
        Name = name;
    }
    
    public string Name { get; private set; }

    public void MakeSound()
    {
        Console.WriteLine("Animal sound");
    }
    
    public virtual void MakeSound2()
    {
        Console.WriteLine("Animal sound 2");
    }
}