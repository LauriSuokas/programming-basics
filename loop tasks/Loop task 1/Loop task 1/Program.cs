using System;

namespace Loop_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program solves factorials");
            int number = 0; //int number;
            int i = 1;
            int fact = 1;
            Console.WriteLine("Input number");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine($"{number}! = {fact}");
        }
    }
}
