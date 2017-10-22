using System;

namespace FirstCharReturner
{
    /// <summary>
    /// Extension methods for strings.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Finds first char in a string.
        /// </summary>
        /// <param name="s">A string to take first char from.</param>
        /// <returns>First char contained in s.</returns>
        public static char FirstChar(this string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            if (s.Length == 0)
            {
                throw new FormatException("Input string cannot be empty.");
            }

            return s[0];
        }
    }
}
