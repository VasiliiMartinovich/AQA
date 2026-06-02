using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace Lesson3;

class Program
{
    static void Main(string[] args)
    {
        // int age = 10;
        // Value type - тип значения
        // Числовые:
        // Со знаком
        sbyte a = 1; // 8 bit
        short b = 2; // 16 bit !
        int c = 3; // 32 bit !
        long d = 4; // 64 bit !
        
        // без знака
        byte e = 5; // 8 bit !
        ushort f = 6; // 16 bit
        uint g = 7; // 32 bit
        ulong h = 8; //64 bit
        
        // вещественные
         float i = 9.1f; // 32 bit
         double j = 10.12d; // 64 bit
         decimal k = 11.32m; // 128 bit
         
         // BigInteger - для огромных чисел

         // Логический
         bool l = true; // 8 bit - дефолтное значение = false
         
         // Символьный
         char c2 = 'a';

         // Reference type - ссылочный тип
         string str = "test"; // в двойных кавычках, под капотом состоит из char
         object o = new object(); // класс, который является родителем для ВСЕХ типов. 
         
         // Преобразование типов

         // int a = 5;
         // long b = a;
         // int c = (int)b;  // будет ошибка

         int a = 5;
         float b = 23.123f;
         int c = (int)b; // при приведении дробного к целочисленному нужно явно указывать тип, но при этом помнить, что мы потеряем дробную часть
             
             // +, -, *, /, %
             int a = 5 + 2;
             int a = 5 - 2;
             int a = 5 * 2;
             int a = 5 / 2; // целочисленное деление, то есть, ответ 2
             double a = 5d / 2d;

             int a = 5;
             a++; // операция инкремент - увеличиваем на 1 число a
             a--; // операция декремент - уменьшаем на 1 число a
             ИЛИ
             ++a;
             --a;

             int a = 5;
             Console.WriteLine(a++);

             int a = 5;
             a += 10; // a = a + 10;
             
             // Побитовые операции - применяются для чисел, но влияют на биты
             int a = ~5; // операция дополнения или инверсии
             Console.WriteLine(Convert.ToString(a, 2));

             int a = 9 & 3; // & - И. если две единицы, то единица
             int a = 9 | 3; // | - ИЛИ. если одна единица, то нуль
             int a = 9 ^ 3; // ^ - исключающее ИЛИ.
             int a = 9 >> 3; // >> - сдвиг влево

             bool a = 2 > 5; // false
             bool a = 2 < 5; // true
             bool a = 2 == 5; // false, оператор равно
             bool a = 2 != 5; // true, оператор не равно
             bool a = (2 > 5) || (3 > 5); // false ||- ИЛИ
             bool a = (2 < 5) || (3 < 5); // true
             bool a = (2 > 5) || (3 < 5); // true
             
             bool a = (2 > 5) && (3 > 5); // false &&- И
             bool a = (2 < 5) && (3 < 5); // true
             bool a = (2 > 5) && (3 < 5); // false

             bool c = true;
             bool d = !c; //в d будет false
         
         // Stack:
         // enum
         // struct
         // record struct
         
         // Heap:
         // class
         // interface
         // delegate
         // record

         int DoubleValue(int a)
         {
             object b = new object(); //дефолтное значение - null
             return b;
         }
         
         //ОПЕРАТОРЫ
         int a = 3;
         int b = 6;

         if (a > b)
         {
             Console.WriteLine("A is bigger");
         }
         
         int a = 3;
         int b = 6;

         if (a > b)
         {
             Console.WriteLine("A is bigger");
         }
         else
         {
             Console.WriteLine("A is less");
         }
         
         int a = 3;
         int b = 6;

         if (a > b)
         {
             Console.WriteLine("A is bigger");
         }
         else if (a == b)
         {
             Console.WriteLine("A is equal");
         }
         else 
         {
             Console.WriteLine("A is less");  
         }
         
         //SWITCH
         int a = 3;
         int b = 6;

         switch (b)
         case 1:
         break;

// while
// do while
// for
    }
    
    class Program
{
    // SWITCH
    
    static void Main()
    {
        Console.Write("Введите число от 1 до 3: ");
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case 1:
                Console.WriteLine("Вы ввели единицу");
                break;

            case 2:
                Console.WriteLine("Вы ввели двойку");
                break;

            case 3:
                Console.WriteLine("Вы ввели тройку");
                break;

            default:
                Console.WriteLine("Число вне диапазона 1–3");
                break;
        }
    }
    // while
    
    /*static void  Main()
    {
        int a = 7;
        int b = 10;
        
        while (a < 10)
        {
            Console.WriteLine("Hello!");
            a++;
        }
        Console.WriteLine("Finished!");
    }*/
    
    // do while
    /*static void  Main()
    {
        int a = 8;
        int b = 10;

        do
        {
            Console.WriteLine($"Hello! {a}");
            a++;
        } while (a < 10);
        
        Console.WriteLine("Hello!");
        }*/
    
    // for
    /*static void  Main()
    {
        int a = 5;
        int b = 10;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Hello! {i}");
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine($"Hello J! {j}");
            }
        } 
        
        Console.WriteLine("Finished!");
    }*/
    
    // for + continue - пропустить шаг, когда будет выполняться условие if
    /*static void  Main()
    {
        int a = 5;
        int b = 10;

        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
           {
               continue;
            }
            Console.WriteLine($"Hello! {i}");
        } 
        
        Console.WriteLine("Finished!");
    }*/
    
    // for + break - завершить выполнение, когда выполнится условие if
    /*static void  Main()
    {
        int a = 5;
        int b = 10;

        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                break;
            }
            Console.WriteLine($"Hello! {i}");
        } 
        
        Console.WriteLine("Finished!");
    }*/
    
    // for + return
    /*static void  Main()
    {
        int a = 5;
        int b = 10;

        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                return;
            }
            Console.WriteLine($"Hello! {i}");
        } 
        
        Console.WriteLine("Finished!");
    }*/
    // for + throw - завершить выполнение с ошибкой
    /*static void  Main()
    {
        int a = 5;
        int b = 10;

        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                throw new Exception();
            }
            Console.WriteLine($"Hello! {i}");
        } 
        
        Console.WriteLine("Finished!");
    }*/
} 
}