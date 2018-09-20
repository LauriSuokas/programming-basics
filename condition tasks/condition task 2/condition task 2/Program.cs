using System;

namespace condition_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko luku parillinen vai pariton");
            Console.Write("Syötä numero: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            if (number % 2 == 0)
                Console.WriteLine($"Luku {number} on parillinen");

            else
                Console.WriteLine($"Luku {number} on pariton");

        }
    }
}
