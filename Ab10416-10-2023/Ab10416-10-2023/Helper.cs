using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab10416_10_2023
{
    public static class Helper
    {
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }

        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static bool HasDigit(this string text)
        {
            return !string.IsNullOrEmpty(text) && text.Any(char.IsDigit);
        }

        public static bool CheckPassword(this string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
            {
                return false;
            }

            bool isLower = password.Any(char.IsLower);
            bool isUpper = password.Any(char.IsUpper);
            bool isDigit = password.Any(char.IsDigit);

            return (isLower && isUpper && isDigit);
        }

        public static string Capitalize(this string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }

            return char.ToUpper(text[0]) + text.Substring(1);
        }
    }

}
