using System;

namespace exercise1._1
{
    class Program
    {
        static void Main(string[] args)
        {
           string name;

            System.Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            for (int counter = 0; counter < 10; counter++)
            {
                for (int counter1 = 0; counter1 < 10; counter1++)
                {
                System.Console.Write(name+" ");
                }
                System.Console.WriteLine();
            }   
        }
    }
}
