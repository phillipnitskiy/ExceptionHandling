using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToInt
{
    public static class StringHelpers
    {
        public static int ToInt(this string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            if (str.IsValid())
            {
                throw new FormatException("Input string has invalid format.");
            }


            return 1;
        }

        private static bool IsValid(this string str)
        {
            if (str.Length == 0)
            {
                return false;
            }
            if (str.HasOnlyDigits())
            {             
                return true;
            }
            if (str.Length > 1 && str.HasSign() && str.Substring(1).HasOnlyDigits())
            {
                return true;
            }

            return false;
        }

        private static bool HasSign(this string str)
        {
            return str.StartsWith("+") || str.StartsWith("-");
        }

        private static bool HasOnlyDigits(this string str)
        {
            return str.All(x => char.IsDigit(x));
        }

    }
}
