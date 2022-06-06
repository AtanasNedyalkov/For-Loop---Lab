using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstSum = 0;
            int secondSum = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSum += number;
            }
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondSum += number;
            }
            if (firstSum==secondSum)
            {
                Console.WriteLine($"Yes, sum = {firstSum} ");
            }
            else
            {
                int difference = firstSum - secondSum;
                Console.WriteLine($" No, diff = {Math.Abs(difference)}");
            }
        }
    }
}
