using System;

namespace FirstCharReturner
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
                    Console.WriteLine(input.FirstChar());
                }
                catch (Exception e) when (e is FormatException || e is ArgumentNullException)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
