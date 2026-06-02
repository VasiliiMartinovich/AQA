using System.Security.Cryptography;

namespace Lesson4;

class Program
{
    static void Main(string[] args)
        /*{
            int[] nums = { 12, 44, 44, 34 };
        }*/
        /*{
            int[,] nums = new int[2, 2]; // прямоугольные массивы

            nums[0, 1] = 111;
        }*/
        /*{
            int[,] matrix = // прямоугольные массивы
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };
        }*/


        /*int[][] nums = new int[3][]; //зубчатый массив
    }*/
        /*{
             int[] numbers = { 32, 44, 54, 34, 1, 22 };
             foreach (int number in numbers)
             {
                 return;
             }
         }*/
        /*{
            Random random = new Random();
            int value = random.Next(100, 200); //выдаст рандомное число из промежутка 101-199
        }*/
        /*{
            int value2 = RandomNumberGenerator.GetInt32(int.MaxValue); //в любом случае нужно задать значение
        }*/
        /*{
            int[] numbers = { 12, 13, 5, 7, 98 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }*/

        /*{
            Random random = new Random();

            int[] numbers = new int[500];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next();
            }
        }*/
        /*int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }#1#*/
        /*{
            unsafe
            {
                int[] numbers = { 10, 20, 30 };
                fixed (int* ptr = numbers)
                {
                    Console.WriteLine(*(ptr + 2));
                }
            }
        }*/
        /*{
            int[] array = new int[10];
            int bound = array.GetLowerBound(0); //возвращает минимальный индекс в массиве
            var array = Array.CreateInstance(typeof(int), new int[]{5}, new int[] {3});
        }*/
    /*{
        var array = new[] { 12, 54, 4, 43 };
        Console.WriteLine(array[^1]); //вывод последнего элемента массива
    }*/
    /*{
        var array = new[] { 12, 54, 4, 43 };
        Console.WriteLine(string.Join(", ", array[..])); //вывод каждого элемента массива
    }*/
    /*{
        var array = new[] { 12, 54, 4, 43 };
        Console.WriteLine(string.Join(", ", array[^2..])); //вывод последних 2ух элементов массива
    }*/
    /*{
        var array = new[] { 12, 54, 4, 43 };
        Console.WriteLine(string.Join(", ", array[..2])); //вывод первых 2ух элементов массива
    }*/
        {
        var array = new[] { 12, 54, 4, 43 };
        Console.WriteLine(string.Join(", ", array[1..^1])); //вывод без первого и последнего элементов массива
    }
}