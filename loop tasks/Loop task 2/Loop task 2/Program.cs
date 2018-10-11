using System;

namespace Loop_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program solves factorials");
            int number = 0;
            int i = 1;
            int summ = 0;
            Console.WriteLine("Input number");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                summ = summ + i;
            }
            Console.WriteLine($"Summ is {summ}");
        }
    }
}
