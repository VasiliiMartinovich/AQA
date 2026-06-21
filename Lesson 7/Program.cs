namespace Lesson_7;

/*class Program
{
    static void Main(string[] args)
    {
        BankAccount bank = new BankAccount();
        bank.Balance = 8;
    }
}

internal class BankAccount
{
    private double balance;

    public double Balance
    {
        get { return balance; }
        set
        {
            if (value >= 0)
                balance = value;
            else
                Console.WriteLine("Insufficient balance");
        }
    }
}*/

class Program
{
    static void Main(string[] args)
    {
        Cat cat = new Cat();
        cat.Name = "Michael";
        cat.Age = -20;
        
        Console.WriteLine(cat.Name);
        Console.WriteLine(cat.Age);
        
    }
}

class Cat
{
    public string _name;
    public int _age;

    public string Name
    {
        get { return _name.ToUpper(); } // get =>_name;
        set { _name = value; } // set => _name = value;
    }
    
    public int Age
    {
        get { return _age; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Error. Wrong Age.");
                _age = 0;
            }
            else
            {
                _age = value;
            }
        }
    }
}

/*class Cat
{
   public int Age { get; set; } // автосвойство - автоматически под капотом создаст переменную age и заполнит стандартными записями
}*/

/*struct Pint
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}*/