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
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
