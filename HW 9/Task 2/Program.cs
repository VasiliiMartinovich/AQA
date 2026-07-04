// namespace HW_9.Task_2;
// // Создайте класс UserValidator, который проверяет корректность email и пароля, выбрасывая различные исключения.
// // Метод ValidateEmail(string email):
// // Проверка: email не пустой
// // Проверка: содержит @
// // Проверка: содержит . после @
// // Проверка: длина > 5 символов
// // Исключения: ArgumentException, FormatException
// // Метод ValidatePassword(string password):
// // Проверка: длина >= 8 символов
// // Проверка: содержит хотя бы одну заглавную букву
// // Проверка: содержит хотя бы одну цифру
// // Проверка: содержит хотя бы один специальный символ (!@#$%^&*)
// // Исключения: ArgumentException, WeakPasswordException (своё)
//
// public class Program
// {
//     static void Main(string[] args)
//     {
//         Console.OutputEncoding = System.Text.Encoding.UTF8;
//         Console.InputEncoding = System.Text.Encoding.UTF8;
//
//         Console.WriteLine("Введите email: ");
//         string email = Console.ReadLine();
//         
//         Console.WriteLine("Введите password: ");
//         string password = Console.ReadLine();
//         
//         try
//         {
//             UserValidator.ValidateEmail(email);
//             UserValidator.ValidatePassword(password);
//             
//             Console.Write("Успех ");
//         }
//         catch (ArgumentException ex)
//         {
//             Console.WriteLine($"Ошибка аргумента: {ex.Message}");
//         }
//         catch (FormatException ex)
//         {
//             Console.WriteLine($"Ошибка формата: {ex.Message}");
//         }
//         catch (WeakPasswordException ex)
//         {
//             Console.WriteLine($"Слабый пароль: {ex.Message}");
//         }
//     }
// }
//
// public class WeakPasswordException : Exception
// {
//     public WeakPasswordException(string message)
//         : base(message)
//     {
//     }
// }