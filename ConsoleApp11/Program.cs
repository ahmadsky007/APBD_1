using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            double average = CalculateAverage(numbers);
            Console.WriteLine($"The average is: {average}");
        }

        static double CalculateAverage(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return (double)sum / nums.Length;
        }
    }
}