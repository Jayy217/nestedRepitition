using System;

namespace exercise2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;

            for (int counter1 = 5; counter1 > 0; counter1--) {
                
                for (int counter = i; counter < 5; counter++) {
                    System.Console.Write("x");
                }

                System.Console.WriteLine();
                i--;
            }
        }
    }
}
