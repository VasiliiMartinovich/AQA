namespace HW_9;

class Calculator
{
    public static double Calculate(string expression)
    {
        if (string.IsNullOrWhiteSpace(expression))
            throw new ArgumentException("Пустая строка");
        
        string[] parts = expression.Split(' ');
        
        if (parts.Length != 3)
            throw new FormatException("Неверный формат!");

        double firstNumber = Convert.ToDouble(parts[0]);
        double secondNumber = Convert.ToDouble(parts[2]);

        switch (parts[1])
        {
            case "+":
                return firstNumber + secondNumber;

            case "-":
                return firstNumber - secondNumber;;

            case "*":
                return firstNumber * secondNumber;;

            case "/":
                if (secondNumber == 0)
                    throw new DivideByZeroException("Деление на ноль");
                return firstNumber / secondNumber;

            default:
                throw new NotSupportedException("Неизвестная операция");
        }
    }
}
