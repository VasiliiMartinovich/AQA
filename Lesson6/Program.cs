namespace Lesson6
{
    // class Program
    // {
    //   static void Main()
    //   {
    //     Cat cat1 = new();
    //     Cat cat2 = new Cat(); //new cat - Экземпляр класса
    //     }
    // }
    //
    // public class Cat
    // {
    //   private int _age; // поле - переменная, которая объявлена внутри класса (не внутри метода) и хранит состояние объекта и класса
    // }
    // class Program
    // {
    //   static void Main()
    //   {
    //     Circle c = new Circle(20);
    //   }
    // }
    //
    // public class Circle
    // {
    //   private int _radius; // данные записываются в поле (переменную) класса _radius
    //   public Circle(int radius)
    //   {
    //     _radius = radius;
    //     Console.WriteLine("The circle radius is: " + _radius);
    //   }
    // }


    // class Program
    // {
    //   static void Main()
    //   {
    //     Cat cat = new Cat(12, "Nick");
    //     Cat cat2 = new Cat("Sam");
    //   }
    //
    //   public class Cat
    //   {
    //     private int _age;
    //     private string _name;
    //
    //     public Cat(int age, string name)
    //     {
    //       _age = age;
    //       _name = name;
    //     }
    //
    //     public Cat(string name)
    //     {
    //       _age = 0;
    //       _name = name;
    //     }
    //   }
    // }
    // class Program
    // {
    //   static void Main()
    //   {
    //     Cat cat = new Cat(12, "Nick");
    //     Cat cat2 = new Cat("Sam");
    //   }
    //
    //   public class Cat
    //   {
    //     private int _age;
    //     private string _name;
    //
    //     public Cat(int age, string name)
    //     {
    //       _age = age;
    //       _name = name;
    //     }
    //
    //     public Cat(string name): this(0, name)
    //     {
    //       _name = name;
    //     }
    //   }
    // }
    // class Program
    // {
    //   static void Main()
    //   {
    //     Cat cat = new Cat(12, "Nick");
    //     var age = cat.GetAge();
    //   }
    //
    //   public class Cat(int age, string name)
    //   {
    //     public int GetAge() // вызывая функцию, пишем то, что она делает
    //     {
    //       return age;
    //     }
    //   }
    // }
    // class Program
    // {
    //   static void Main()
    //   {
    //     Cat cat = new("Sam");
    //     cat.Age = 4;
    //     DoubleAge(cat);
    //   }
    //
    //   static void DoubleAge(Cat cat)
    //   {
    //     cat.Age *= 2;
    //   }
    //
    //   public class Cat(string name)
    //   {
    //     public int Age;
    //   }
    // }
    // class Person
    // {
    //   // поля
    //   public string Name;
    //   public int Age;
    //
    //   // конструктор
    //   public Person(string name, int age)
    //   {
    //     Name = name;
    //     Age = age;
    //   }
    //
    //   // метод
    //   public void SayHello()
    //   {
    //     Console.WriteLine("Привет!");
    //   }
    //
    //   // метод с параметрами
    //   public int Sum(int a, int b)
    //   {
    //     return a + b;
    //   }
    // }
    /*class Program
    {
        static void Main(string[] args)
        {
            Cat nick = new Cat("Nikolay", 5);
            Console.WriteLine(nick.GetInfo());
            nick.Walk(10);
            Console.WriteLine(nick.GetInfo());
            nick.Sleep(10);
            Console.WriteLine(nick.GetInfo());
            nick.Eat(200);  
            Console.WriteLine(nick.GetInfo());
        }
    }

    public class Cat(string name, int age)
    {
        private double _powers = 15;
        private double _hunger = 25;
        

        public void Eat(int value)
        {
            _powers *= value * 0.01;
            _hunger /= value * 0.1;
        }

        public void Walk(int distance)
        {
            _powers /= distance * 0.25; //_powers = _powers / (distance * 0.25);
            _hunger = distance * (double)5;
        }

        public void Sleep(int duration)
        {
            _powers = duration * (double)2;
        }

        public string GetInfo()
        {
            return $"Powers: {_powers}, Hunger: {_hunger}";
        }

    }*/
    static void Say(int id, string message = "default message")
    {
        Console.WriteLine(id + ": ");
        Console.WriteLine(message);
    }
}
    
