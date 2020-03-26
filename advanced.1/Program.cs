using System;

namespace advanced._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            for (int counter = 11; counter > 0; counter = counter - 2)
            {
                for (int space = i; space > 0; space--)
                {
                    System.Console.Write(" ");
                }
                for (int counter1 = counter; counter1 > 0; counter1--)
                {
                    System.Console.Write("x");
                }

                System.Console.WriteLine();
                i++;
            }
        }
    }
}