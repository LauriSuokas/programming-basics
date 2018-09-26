using System;

namespace Condition_task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma lajittelee luvut nousevaan järjestykseen");
            Console.WriteLine("Syötä 1. luku: ");
            string userInput = Console.ReadLine();

            int number = int.Parse(userInput);
            Console.Write("Syötä 1. luku");

            int number1 = int.Parse(userInput);
            Console.Write("Syötä 2. luku");

            int number2 = int.Parse(userInput);
            Console.Write("Syötä 3. luku");

            if (number < number1)
            {
                if (number1 < number2)
                    Console.WriteLine($"Luku {number}, {number1}, {number2}");

                else
                {
                    Console.WriteLine($"Luku {number}, {number2}, {number1}");
                    if (number1 < number)
                        Console.WriteLine($"Luku {number1}, {number}, {number2}");
                }

            }
        }
    }
}
