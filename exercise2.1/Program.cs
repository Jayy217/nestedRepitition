using System;

namespace exercise2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 5; counter > 0; counter--) {

                for (int counter1 = counter; counter1 > 0; counter1--) {
                    System.Console.Write("x");
                }

                System.Console.WriteLine();
            }
        }
    }
}
