using System;

namespace Loop_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program solves odd and even numbers sum");
            int number = 0;
            int i = 0;
            int evenSum = 0;
            int oddSum = 0;
            do
            {
                Console.WriteLine("Input number");
                number = int.Parse(Console.ReadLine());
                if (number <= 0)
                    Console.WriteLine("Wrong input");
            }
            while (number <= 0);

            for (i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                    evenSum = evenSum + i;
                else
                    oddSum = oddSum + i;
            }
            Console.WriteLine($"Sum of even numbers is {evenSum}");
            Console.WriteLine($"Sum of odd numbers is {oddSum}");
        }
    }
}
