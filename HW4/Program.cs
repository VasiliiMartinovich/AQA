namespace HW4;

class Program
{
/*1. Создайте массив целых чисел. Напишите программу, которая выводит сообщение
о том, входит ли заданное число в массив или нет. Пусть число для поиска
задается с консоли.*/
    /*static void Main(string[] args)
    {
        int[] numbers = { 32, 44, 54, 34, 1, 30, 35 };

        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        foreach (int i in numbers)
        {
            if (i == number)
            {
                Console.WriteLine("Заданное число входит в массив");
                return;
            }
        }
        Console.WriteLine("Заданное число не входит в массив");
    }
}*/
    /*Задание 2.
    Создайте массив целых чисел. Удалите все вхождения заданного числа из
        массива.
        Пусть число задается с консоли. Если такого числа нет - выведите сообщения об
        этом.
        В результате должен быть новый массив без указанного числа.*/

    /*static void Main(string[] args)
    {
        int[] numbers = { 32, 44, 54, 34, 1, 32, 35 };
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int count = 0;

        foreach (int i in numbers)
        {
            if (i != number)
            {
                count++;
            }
        }

        if (!numbers.Contains(number))
        {
            Console.WriteLine("Заданное число не входит в массив");
            return;
        }
        int[] result = new int[count];
        int index = 0;

        foreach (int i in numbers)
        {
            if (i != number)
            {
                result[index] = i;
                index++;
            }
        }
        Console.WriteLine("Новый массив:");
        Console.WriteLine(string.Join(", ", result));
    }
}*/

/*Задание 3
Создайте и заполните массив случайными числами и выведете максимальное,
минимальное и среднее значение.
Пусть будет возможность создавать массив произвольного размера. Пусть размер массива
вводится с консоли.*/

    /*static void Main(string[] args)
    {
        Random random = new Random();
        Console.Write("Введите размер массива: ");
        int array = int.Parse(Console.ReadLine());
        
        int[] numbers = new int[array];
        
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1000);
        }
        Console.WriteLine("Новый массив:");
        Console.WriteLine(string.Join(", ", numbers));
        
        int maxNum = numbers[0];
        int minNum = numbers[0];
        int sum = 0;
        
        foreach (int num in numbers)
        {
            if (num > maxNum)
            {
                maxNum = num;
            }
        }
        foreach (int num in numbers)
        {
            if (num < minNum)
            {
                minNum = num;
            }
        }
        foreach(int num in numbers)
            sum += num;

        Console.WriteLine("Максимальное число: ");
        Console.WriteLine(maxNum);
        Console.WriteLine("Минимальное число: ");
        Console.WriteLine(minNum);
        Console.WriteLine("Среднее число: ");
        Console.WriteLine((double)sum / numbers.Length);
    }
}*/


/*Задание 4
Создайте двумерный массив целых чисел. Выведите на консоль сумму всех
    элементов массива.*/
    /*static void Main(string[] args)
    {
        int sum = 0;
        int[,] arr =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
            { 22, 3, 44}
        };
        foreach (int num in arr)
            sum += num;

        Console.WriteLine("Сумма всех элементов массива: ");
        Console.WriteLine(sum);
    }
}*/

/*Задание 5 - РЕШЕНИЕ ОТ ИИ, я не понял)))
Создайте двумерный массив. Выведите на консоль диагонали массива.*/
    /*static void Main(string[] args)
    {
        int[,] matrix =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int n = matrix.GetLength(0);

        Console.WriteLine("Главная диагональ:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(matrix[i, i] + " ");
        }

        Console.WriteLine("\nПобочная диагональ:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(matrix[i, n - 1 - i] + " ");
        }
    }
}*/