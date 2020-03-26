using System;

namespace advanced._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            int n = 4;

            for (int counter1 = 5; counter1 > 0; counter1--)
            {
                for (int space = n; space > 0; space--)
                {
                    System.Console.Write(" ");
                }
                for (int counter = i; counter < 5; counter++)
                {
                    System.Console.Write("x");
                }

                System.Console.WriteLine();
                i = i - 2;
                n--;
            }
        }
    }
}