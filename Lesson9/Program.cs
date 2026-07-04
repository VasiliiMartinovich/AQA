namespace Lesson9;

// class Program
// {
//     static void Main(string[] args)
//     {
//         var myClass = new MyClass();
//
//         try
//         {
//             myClass.MyMethod();
//         }
//         catch (DivideByZeroException exception)
//         {
//             Console.WriteLine(exception.Message);
//         }
//         Console.WriteLine("Still working");
//         
//     }
// }
//
// class MyClass
// {
//     public void MyMethod()
//     {
//         int aa = 5;
//         int bb = 5;
//         int a = 5 / (aa - bb);
//     }
// }



// class Program
// {
//     static void Main(string[] args)
//     {
//         var myClass = new MyClass();
//
//         int rnd = new Random().Next();
//         Console.WriteLine(rnd);
//         try
//         {
//             myClass.MyMethod(rnd);
//         }
//         catch (DivideByZeroException
//                exception) // исключения обрабатываются в том порядке, в котором написали. Более специфичные должны быть выше
//         {
//             Console.WriteLine(exception.Message);
//         }
//         // catch (IndexOutOfRangeException exception)
//         // {
//         //     Console.WriteLine(exception.Message);
//         // }
//         catch (Exception exception)
//         {
//             Console.WriteLine($"Common {exception.Message}");
//         }
//         finally
//         {
//             rnd = 0;
//         }
//         Console.WriteLine("Still working");
//     }
// }
//
// class MyClass
// {
//     public void MyMethod(int rnd)
//     {
//         if (rnd % 2 == 0)
//         {
//             int aa = 5;
//             int bb = 5;
//             int a = 5 / (aa - bb);
//         }
//         else
//         {
//             int[] x = { 1, 2, 3 };
//             int y = x[10];
//         }
//     }
// }


class Program
{
    static void Main(string[] args)
    {
        var myClass = new MyClass();

        int rnd = new Random().Next();
        Console.WriteLine(rnd);
        try
        {
            myClass.MyMethod(2);
        }
        catch (DivideByZeroException
               exception) // исключения обрабатываются в том порядке, в котором написали. Более специфичные должны быть выше
        {
            Console.WriteLine(exception.Message);
        }
        // catch (IndexOutOfRangeException exception)
        // {
        //     Console.WriteLine(exception.Message);
        // }
        // catch (Exception exception)
        // {
        //     Console.WriteLine($"Common {exception.Message}");
        // }
        finally
        {
            rnd = 0;
        }
        Console.WriteLine("Still working");
    }
}

class MyClass
{
    public void MyMethod(int rnd)
    {
        if (rnd % 2 == 0)
        {
            int aa = 5;
            int bb = 5;

            if (aa == bb)
            {
                // DivideByZeroException e = new DivideByZeroException("Custom message");
                MyFirstException e = new MyFirstException();
                throw e; // выбросить ошибку new DivideByZeroException("Custom message")
            }
            int a = 5 / (aa - bb);
        }
        else
        {
            int[] x = { 1, 2, 3 };
            int y = x[10];
        }
    }
}