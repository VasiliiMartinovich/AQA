namespace HW3;

class Program
{
    /*Задание 1
    Напишите программу - консольный калькулятор.
        Создайте две переменные с именами operand1 и operand2.
        Задайте переменным некоторые произвольные значения.
        Предложите пользователю ввести знак арифметической операции.
        Примите значение, введенное пользователем, и поместите его в строковую переменную sign.
        Для организации выбора алгоритма вычислительного процесса, используйте
        переключатель switch.
    Выведите на экран результат выполнения арифметической операции.
        В случае использования операции деления, организуйте проверку попытки деления на
        ноль.
        И если таковая имеется, то отмените выполнение арифметической операции и
    уведомите об ошибке пользователя.*/
    /*string input = Console.ReadLine();
    int value = int.Parse(input);*/
    static void Main(string[] args)
    {
        double operand1 = 10.0d;
        double operand2 = 2d;
        {
            Console.WriteLine("Enter operation sign (+, -, *, /): ");
            string sign = Console.ReadLine();
            string value = sign.ToString();

            switch (sign)
            {
                case "+":
                    Console.WriteLine($"Result: {operand1 + operand2}");
                    break;

                case "-":
                    Console.WriteLine($"Result: {operand1 - operand2}");
                    break;

                case "*":
                    Console.WriteLine($"Result: {operand1 * operand2}");
                    break;

                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Error: divide by zero!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Result: {operand1 / operand2}");
                    }

                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}
    
    /*Задание 2
    Напишите программу определения, попадает ли указанное пользователем число от 0 до
    100 в числовой промежуток [0 - 14] [15 - 35] [36 - 50][51 - 100].
    Если да, то укажите, в какой именно промежуток.
        Если пользователь указывает число, не входящее ни в один из имеющихся числовых
    промежутков, то выводится соответствующее сообщение.*/

 /*static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case int n when n >= 0 & n <= 14:
                Console.WriteLine("0 - 14");
                break;

            case int n when n >= 15 & n <= 36:
                Console.WriteLine("15 - 36");
                break;

            case int n when n >= 36 & n <= 50:
                Console.WriteLine("36 - 50");
                break;

            case int n when n >= 51 & n <= 100:
                Console.WriteLine("51 - 100");
                break;

            default:
                Console.WriteLine("The number is out of range");
                break;
        }
    }*/
    
    // variant 2
    
    /*static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 0 && number <= 14)
        {
            Console.WriteLine("0 - 14");
        }
        else if (number >= 15 && number <= 36)
        {
            Console.WriteLine("15 - 36");
        }
        else if (number >= 36 && number <= 50)
        {
            Console.WriteLine("36 - 50");
        }
        else if (number >= 51 && number <= 100)
        {
            Console.WriteLine("51 - 100");
        }
        else 
        {
            Console.WriteLine("The number is out of range");
        }
    }*/
    
    /*Задание 3
    Напишите программу русско-английский переводчик.
        Программа знает 10 слов о погоде.
        Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему
    перевод этого слова на английском языке.
        Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести
    сообщение, что такого слова нет.*/
    
    /*static void Main()
    {
        Console.WriteLine("Enter a world: ");
        string word = Console.ReadLine();
        string value = word.ToString();

        if (word == "погода" | word == "Погода")
        {
            Console.WriteLine("Weather");
        }
        else if (word == "дождь" | word == "Дождь")
        {
            Console.WriteLine("Rain");
        }
        else if (word == "снег" | word == "Снег")
        {
            Console.WriteLine("Snow");
        }
        else if (word == "солнце" | word == "Солнце")
        {
            Console.WriteLine("Sun");
        }
        else if (word == "прогноз" | word == "Прогноз")
        {
            Console.WriteLine("Forecast");
        }
        else if (word == "осадки" | word == "Осадки")
        {
            Console.WriteLine("Precipitation");
        }
        else if (word == "метель" | word == "Метель")
        {
            Console.WriteLine("Blizzard");
        }
        else if (word == "ураган" | word == "Ураган")
        {
            Console.WriteLine("Hurricane");
        }
        else if (word == "засуха" | word == "Засуха")
        {
            Console.WriteLine("Drought");
        }
        else if (word == "мороз" | word == "Мороз")
        {
            Console.WriteLine("Frost");
        }
        else 
        {
            Console.WriteLine("The word is missing from the dictionary");
        }
    }*/
    
    /*Задание 4
    Напишите программу, которая будет выполнять проверку чисел на четность.
    *Предложите два варианта решения поставленной задачи.*/

    /*static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 != 0)
        {
            Console.WriteLine("Odd number");
        }
        else
        {
            Console.WriteLine("Even number");
        }
    }*/
    
    //variant №2
    /*static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case int a when a % 2 != 0:
                Console.WriteLine("Odd number");
                break;
            
            case int a when a % 2 == 0:
            Console.WriteLine("Even number");
            break;
        }
    }*/
