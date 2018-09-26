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
            Console.WriteLine("Syötä 2. luku");
            userInput = Console.ReadLine();

            int number1 = int.Parse(userInput);
            Console.WriteLine("Syötä 3. luku");
            userInput = Console.ReadLine();

            int number2 = int.Parse(userInput);


            if (number > number1)
            {
                if (number1 > number2)
                    Console.WriteLine($"Luku {number2}, {number1}, {number}");

                else
                {
                    if (number2 < number)
                        Console.WriteLine($"Luku {number1}, {number2}, {number}");
                    else
                        Console.WriteLine($"Luku {number1}, {number}, {number2}");
                }
            }
            else
            {
                if (number > number2)
                    Console.WriteLine($"Luku {number2}, {number}, {number1}");
                else
                {
                    if (number1 < number2)
                        Console.WriteLine($"Luku {number}, {number1}, {number2}");
                    else
                        Console.WriteLine($"Luku {number}, {number2}, {number1}");
                }
            }
        }
    }
}
