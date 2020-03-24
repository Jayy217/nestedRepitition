using System;

namespace exercise2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            System.Console.WriteLine("How many Xs would you like to start with?");
            x = int.Parse(Console.ReadLine());

            for (int counter = x; counter > 0; counter--)
            {
                for (int counter1 = x; counter1 > 0; counter1--)
                {
                    System.Console.Write("x");
                }
                System.Console.WriteLine();
                x--;
            }
        }
    }
}
