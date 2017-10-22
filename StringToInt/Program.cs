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
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (OverflowException e)
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
