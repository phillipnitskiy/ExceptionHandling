using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCharReturner
{
    public static class StringHelpers
    {
        public static char FirstChar(this string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            if (str.Length == 0)
            {
                throw new FormatException("Input string cannot be empty.");
            }

            return str[0];
        }
    }
}
