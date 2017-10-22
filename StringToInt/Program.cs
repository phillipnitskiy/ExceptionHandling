using System;

namespace StringToInt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();

                try
                {
                    Console.WriteLine(input.ToInt());
                }
                catch (Exception e) when (e is FormatException || e is OverflowException || e is ArgumentNullException)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
