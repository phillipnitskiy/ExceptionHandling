using System;
using System.Linq;

namespace StringToInt
{
    /// <summary>
    /// Extension methods for strings.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Converts the string representation of a number to its integer equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <returns>An equivalent to the number contained in s.</returns>
        public static int ToInt(this string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }

            s = s.Trim();

            if (!s.IsValid())
            {
                throw new FormatException("Input string has invalid format.");
            }

            int sign = s.GetSign();
            if (s.HasSign())
            {
                s = s.Substring(1);
            }

            int result = 0;
            try
            {

                checked
                {
                    result = s
                        .Select((c, i) => (c - '0') * (int)Math.Pow(10, (s.Length - i - 1)))
                        .Sum(); 
                }
            }
            catch (OverflowException)
            {
                throw new OverflowException("Input value was too big or too smal for int.");
            }

            return result * sign;
        }

        private static bool IsValid(this string s)
        {
            if (s.Length == 0)
            {
                return false;
            }
            if (s.HasOnlyDigits())
            {             
                return true;
            }
            if (s.Length > 1 && s.HasSign() && s.Substring(1).HasOnlyDigits())
            {
                return true;
            }

            return false;
        }

        private static bool HasSign(this string s)
        {
            return s.StartsWith("+") || s.StartsWith("-");
        }

        private static bool HasOnlyDigits(this string str)
        {
            return str.All(x => char.IsDigit(x));
        }

        private static int GetSign(this string s)
        {
            if (s.StartsWith("-"))
            {
                return -1;
            }

            return 1;
        }
    }
}
