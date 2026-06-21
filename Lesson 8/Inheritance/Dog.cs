namespace Lesson_8;

public class Dog : Animal
{
    public Dog(string name) : base(name) { }

    public string Breed { get; set; } = "Ovcharka";
    

    public new void MakeSound()
    {
        base.MakeSound();
        Console.WriteLine("Woof-woof");
    }
    
    public override void MakeSound2()
    {
        base.MakeSound2();
        Console.WriteLine("Woof-woof2");
    }

    public void Fetch()
    {
        Console.WriteLine("Fetching");
    }
}