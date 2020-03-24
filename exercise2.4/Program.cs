using System;

namespace exercise2._4
{
    class Program
    {
        static void Main(string[] args)
        {
             int i;
             int x = 1;

            System.Console.WriteLine("How many Xs would you like to end with?");
            i = int.Parse(Console.ReadLine());

            for (int counter = 0; counter < i; counter++) {

                for (int counter1 = 0; counter1 < x; counter1++) {
                    System.Console.Write("x");
                }
                
                System.Console.WriteLine();
                x++;
            }
        }
    }
}
