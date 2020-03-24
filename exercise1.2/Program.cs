using System;

namespace exercise1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int counter = 1;
            string name;

            System.Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            System.Console.WriteLine("How many times would you like your name printed?");
            i = Int16.Parse(Console.ReadLine());

            while (counter <= i)
            {
                System.Console.Write(name+" ");
                counter++;
            }
        }
    }
}
