namespace Lesson5;

class Program
{
    static void Main(string[] args)
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
        
    }
}