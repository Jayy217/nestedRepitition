using System;

namespace advanced._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int input;

            System.Console.WriteLine("Enter how many lines would you like me to input?");
            input = int.Parse(Console.ReadLine());

            while (input > 0)
            {
                for (int space = input; space > 1; space--)
                {
                    System.Console.Write(" ");
                }
                for (int x = i; x > 0; x--)
                {
                    System.Console.Write("x");
                }
                System.Console.WriteLine();
                i=i+2;
                input--;
            }
        }
    }
}