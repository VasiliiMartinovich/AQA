namespace HW_9;

// Создайте калькулятор, который обрабатывает все возможные ошибки ввода и вычислений.
//     Метод Calculate(string expression):
// Принимает строку вида: "5 + 3", "10 / 2", "7 * 4", "15 - 8"
// Поддерживает операции: +, -, *, /
// Возвращает double
//     Обрабатываемые ошибки:
// Пустая строка -> ArgumentException
// Неверный формат -> FormatException
// Неизвестная операция -> NotSupportedException
// Деление на ноль -> DivideByZeroException
// Слишком большое число -> OverflowException
// Своё исключение:
// CalculationException - для ошибок, связанных с вычислениями

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        
        Console.WriteLine("Введите выражение: ");
        string expression = Console.ReadLine();

        try
        {
            double result = Calculator.Calculate(expression);
            Console.WriteLine($"Результат: {result}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка аргумента: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Ошибка формата: {ex.Message}");
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine($"Ошибка поддержки: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка деления на 0: {ex.Message}");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Ошибка оверфлоу: {ex.Message}");
        }
        catch (CalculationException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}

public class CalculationException : Exception
{
    public CalculationException(string message)
        : base(message)
    {
    }
}
