using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Counting to " + number + ":");
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}