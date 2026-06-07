using System.Text;

namespace HW5;

class Program
{
/*1. Заменить в строке все вхождения 'test' на 'testing'. Удалить из текста все
символы, являющиеся цифрами.*/

    /*static void Main(string[] args)
    {
        string str = "Test 1 produced a result of 15, then test 2 returned a value of 37, and a repeated test 1 after 5 minutes recorded 42.";
        string replace = str.ToLower().Replace("test", "testing");
        StringBuilder sb = new StringBuilder(str.Length);

        foreach (char c in replace)
        {
            if (!char.IsDigit(c))
            {
                sb.Append(c);
            }
        }
        string result = sb.ToString();
        Console.WriteLine(result);
    }
}*/

/*2. Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
Необходимо найти в данной строке "abc", записав всё что до этих символов в первую
переменную, а также всё, что после них во вторую.
Результат вывести в консоль.*/

    /*static void Main(string[] args)
    {
        string str = "teamwithsomeofexcersicesabcwanttomakeitbetter";
        int result = str.IndexOf("abc");
        if (result == -1)
        {
            Console.WriteLine("abc not found");
            return;
        }

        string before = str.Substring(0, result);
        string after = str.Substring(result + 3);

        Console.WriteLine("Before abc: ");
        Console.WriteLine(before);

        Console.WriteLine("After abc: ");
        Console.WriteLine(after);
    }
}*/

/*3. Дана строка: Плохой день.
Необходимо с помощью метода substring удалить слово "плохой". После чего необходимо
используя команду insert создать строку со значением: Хороший день!!!!!!!!!.
Заменить последний "!" на "?"*/

    /*static void Main(string[] args)
    {
        string str = "Плохой день";
        int index = str.IndexOf(' ');
        string remove = str.Substring(index);
        string sentence = remove.Insert(0, "Хороший");
        int i = sentence.IndexOf("ь");
        sentence = sentence.Insert(i+1, "!!!!!!!!!");

        if (sentence[sentence.Length - 1] == '!')
        {
            sentence = sentence.Substring(0, sentence.Length - 1) + "?";
        }
        Console.WriteLine("The whole sentence: ");
        Console.WriteLine(sentence);
    }
}*/

/*4. Написать программу со следующим функционалом:
На вход передать строку (будем считать, что это номер документа).
Номер документа имеет формат xxxx-yyy-xxxx-yyy-xyxy, где x — это число,
а y — это буква.
Вывести на экран в одну строку два первых блока по 4 цифры.
Вывести на экран номер документа, но блоки из трех букв заменить
на *** (каждая буква заменятся на *).
Вывести на экран только одни буквы из номера документа в
формате yyy/yyy/y/y в нижнем регистре.
Вывести на экран буквы из номера документа в формате
"Letters:yyy/yyy/y/y" в верхнем регистре(реализовать с помощью
класса StringBuilder).
Проверить содержит ли номер документа последовательность abc и
вывети сообщение содержит или нет(причем, abc и ABC считается
одинаковой последовательностью).
Проверить начинается ли номер документа с последовательности 555.*/

    static void Main(string[] args)
    {
        Console.WriteLine("Введите номер документа xxxx-yyy-xxxx-yyy-xyxy, где x — это число,\nа y — это буква.: ");
        string docNumber = Console.ReadLine();

        string[] parts = docNumber.Split("-");
        string result = parts[0] + parts[2];
        Console.WriteLine("Два первых блока по 4 цифры: ");
        Console.WriteLine(result);

        string secure = parts[0] + "-***-" + parts[2] + "-***-" + parts[3];
        Console.WriteLine("Замена на *: ");
        Console.WriteLine(secure);

        string block2 = parts[1]; // yyy
        string block4 = parts[3]; // yyy
        string block5 = parts[4]; // xyxy

        string letters =
            block2 + "/" +
            block4 + "/" +
            block5[1] + "/" +
            block5[3];
        Console.WriteLine("Только буквы в нижнем регистре: ");
        Console.WriteLine(letters.ToLower());
        
        StringBuilder str = new StringBuilder();
        str.Append(block2 + "/");
        str.Append(block4 + "/");
        str.Append(block5[1] + "/");
        str.Append(block5[3]);
        string result1 = str.ToString();
        Console.WriteLine("Только буквы в верхнем регистре: "); 
        Console.WriteLine(result1.ToUpper());
        
        string abc = docNumber.ToLower();
        bool result2 = abc.Contains("abc");
        if (result2 == true)
        {
            Console.WriteLine(@"Содержит последовательность ""abc""");
        }
        else
        {
            Console.WriteLine(@"Не содержит последовательность ""abc"""); 
        }
        
        bool result3 = docNumber.StartsWith("555");
        Console.WriteLine("Начинается с \"555\": ");
        Console.WriteLine(result3);
    }
}





   