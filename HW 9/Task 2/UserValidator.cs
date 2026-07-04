// using System.Globalization;
//
// namespace HW_9.Task_2;
//
// public class UserValidator
// {
//     public static void ValidateEmail(string email)
//     {
//         if (string.IsNullOrWhiteSpace(email))
//             throw new ArgumentException("Email пустой!");
//
//         bool result = email.Contains("@");
//         if (result == false)
//             throw new FormatException("Email не содержит @!");
//
//
//         bool dot = email.Contains("@.");
//         if (dot == true)
//             throw new FormatException("Неверный формат!");
//
//         if (email.Length <= 5)
//             throw new FormatException("Недостаточно символов");
//     }
//
//     public static void ValidatePassword(string password)
//     {
//         if (string.IsNullOrWhiteSpace(password))
//             throw new ArgumentException("Пароль пустой");
//
//         if (password.Length < 8) //  Проверка: длина >= 8 символов
//             throw new WeakPasswordException("Недостаточно символов");
//
//
//         bool hasDigit = false; // Проверка: содержит хотя бы одну цифру
//         foreach (char c in password)
//         {
//             if (char.IsDigit(c))
//             {
//                 hasDigit = true;
//                 break;
//             }
//           }
//         if (hasDigit == false)            //как сделать через else? 
//             throw new WeakPasswordException("Не содержит заглавную букву");
//
//         bool hasUpper = false; // Проверка: содержит хотя бы одну заглавную букву
//         foreach (char i in password)
//         {
//             if (char.IsUpper(i))
//             {
//                 hasUpper = true;
//                 break;
//             }
//         }
//
//         if (hasUpper == false)
//              throw new WeakPasswordException("Не содержит заглавную букву");
//
//         bool hasSpecialChars = false; // Проверка: содержит хотя бы один специальный символ (!@#$%^&*)
//         string specialChars = "!@#$%^&*";
//
//         foreach (char y in password)
//         {
//             if (specialChars.Contains(y))
//             {
//                 hasSpecialChars = true;
//                 break;
//             }
//         }
//
//         if (hasSpecialChars == false)
//             throw new WeakPasswordException("Не содержит специальных символов");
//     }
// }
