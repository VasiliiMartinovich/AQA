namespace Lesson_11;

delegate void MyDelegate(string data);

// class Program
// {
//     static void Main(string[] args)
//     {
//         MyDelegate myDelegate = PrintMessage;
//         
//         myDelegate("Hello World! Delegate");
//         
//         PrintMessage("Hello World! Common");
//     }
//
//
//     static void PrintMessage(string msg)
//     {
//         Console.WriteLine(msg);
//     }

//------------------->
// class Program
// {
//     static void Main(string[] args)
//     {
//         MyDelegate myDelegate = PrintMessage;
//         
//         PrintMessage2("Hello World", myDelegate);
//     }
//
//
//     static void PrintMessage(string msg)
//     {
//         Console.WriteLine(msg);
//     }
//
//     static void PrintMessage2(string msg, MyDelegate myDelegate)
//     {
//         myDelegate(msg);
//     }
// }
//------------------------------->
class Program
{
    static void Main(string[] args)
    {
        MyDelegate myDelegateA = PrintMessageA;
        MyDelegate myDelegateB = PrintMessageB;

        if (new Random().Next() % 2 == 0)
        {
            PrintMessage("Hello World!", myDelegateA);
        }
        else
        {
            PrintMessage("Hello World!", myDelegateB);
        }
    }


    static void PrintMessageA(string msg)
    {
        Console.WriteLine(msg.ToLower());
    }
    
    static void PrintMessageB(string msg)
    {
        Console.WriteLine(msg.ToUpper());
    }

    static void PrintMessage(string msg, MyDelegate myDelegate)
    {
        myDelegate(msg);
    }
}
