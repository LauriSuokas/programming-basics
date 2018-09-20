using System;

namespace Condition_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko luku negatiivinen vai positiivinen ja onko luku pariton vai parillinen");
            Console.Write("Syötä numero: ");
            string userInput = Console.ReadLine();
            int number = 0;
            bool isNumber = int.TryParse(userInput, out number);

            if (isNumber)
            {
                if (number == 0)
                    Console.WriteLine("Luku on parillinen ");

                else if (number < 0)

                {
                    if (number % 2 == 0)
                        Console.WriteLine($"Numero {number} on negatiivinen ja parillinen");
                    else
                        Console.WriteLine($"Numero {number} on negatiivinen ja pariton");
                }

                else
                {
                    if (number % 2 == 0)
                        Console.WriteLine($"Numero {number} on positiivnen ja parillinen");
                    else
                        Console.WriteLine($"Numero {number} on positiivinen ja pariton");
                }
            }Console.WriteLine("Virhe");

            
        }
    }
}
