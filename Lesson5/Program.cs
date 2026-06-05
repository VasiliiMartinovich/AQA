using System.Diagnostics;
using System.Text;

namespace Lesson5;

class Program
{
    //static void Main(string[] args)
    /*{
        char a = 'A';
        Console.WriteLine((int)a);
        Console.WriteLine(char.IsLetter(a));
        Console.WriteLine(char.ToLower(a));
        Console.WriteLine(char.IsDigit(a));
        Console.WriteLine(char.IsWhiteSpace(a));
    }*/

    /*string str = "Hello!"; // строка - неизменяемая последовательность символов
    string str = "Hello \"World\""; // \- управляющая последовательность
    string str = @"Hello ""World"""; // \- @ дословная строка

    string str = @"Hello\
World
test";*/

    /*static void Main(string[] args)
    {
        string str = "Hello " + "World"; //   конкатенация строк - операция сложения двух и более текстовых строк в последовательность
        Console.WriteLine(str);
    }
}*/
    /*static void Main(string[] args)
    {
        string s = "string";
        s = s.ToUpper(); // строка - неизменяемый тип (immutable)
    }
}*/

    /*static void Main(string[] args)
    {
        string str = "Hello World";
        bool result = str.Contains("world");
        Console.WriteLine(result);
    }
}*/

    /*static void Main(string[] args)
    {
        string str = "Hello World";
        bool result = str.StartsWith('H');
        Console.WriteLine(result);
    }
}*/
    /*static void Main(string[] args)
    {
        string str = "Hello World";
        int result = str.IndexOf("el");  // если символа нет, то результат (-1)
        Console.WriteLine(result);
    }*/
    /*static void Main(string[] args)
    {
        string str = "Hello World";
        int result = str.IndexOf('o', 5);  // поиск начиная с 5ой позиции
        Console.WriteLine(result);
    }*/
    /*static void Main(string[] args)
    {
        string str = "Hello World";
        string result = str.Substring(8);  // вырезать все, что начинается с 8ой позиции
        Console.WriteLine(result);
    }
    //string result = str.Substring(1, 5); // вырезать 5 символов, которые начинаются с 1го символа
}*/
    /*static void Main(string[] args)
    {
        string str = "Hello World";
        string result = str.Replace("H", "p");  //заменит все H на p
        Console.WriteLine(result);
    }
}*/
    /*static void Main(string[] args)
    {
        string str = "Hello World";
        string[] result = str.Split(" ");  
        Console.WriteLine(result);
    }
}*/
    /*static void Main(string[] args)
    {
        string str = "     Hello  World   ";
        string result = str.Trim();  
        Console.WriteLine(result);
    }
}*/
    /*static void Main(string[] args)
    {
        string a = "xxx";
        string b = "XXX";  
        Console.WriteLine(a.Equals(b, StringComparison.CurrentCultureIgnoreCase));
    }
}*/
    /*static void Main(string[] args)
    {
        string a = "xxx";
        string b = "xxx";  
        Console.WriteLine(ReferenceEquals(a, b)); //проверяются адреса, по которым лежат переменные
    }
}*/
    static void Main(string[] args)
    {
        Stopwatch sw = Stopwatch.StartNew();
        StringBuilder str = new StringBuilder();
        Console.WriteLine(str.Capacity);
        str.Append("Hello World");
        Console.WriteLine(str.ToString());
    }
}

/*static void Main(string[] args)
{
    string a = "Print versions of the book are available on Amazon.com.";
    int count = 0;
    int maxWord = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (!char.IsWhiteSpace(a[i]))
        {
            count++;
        }
        else
        {
            if (count > maxWord)
            {
                maxWord = count;
            }
            count = 0;
        }
    }
    Console.WriteLine(maxWord);

}*/
