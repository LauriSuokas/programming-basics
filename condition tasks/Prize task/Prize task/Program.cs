using System;

namespace Prize_task
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 16;
            double discount = 0;
            Console.WriteLine("Programme will find out ticket price");
            Console.WriteLine("Conscript y/n");
            string userInput = Console.ReadLine();

            if (userInput == "y")
                discount = 0.5;
            else
            {
                Console.WriteLine("Are you student? y/n");
                userInput = Console.ReadLine();
                if (userInput == "y")
                {
                    Console.WriteLine("Are you member of MTK y/n");
                    userInput = Console.ReadLine();
                    if (userInput == "y")
                        discount = 0.6;
                    else
                        discount = 0.45;
                }
                else
                {
                    Console.WriteLine("Input your age");
                    int age = int.Parse(Console.ReadLine());

                    if (age < 7)
                        discount = 1;
                    else if (age >= 7 && age <= 15 || age > 65)
                        discount = 0.5;
                    else
                    {
                        Console.WriteLine("Are you member of MTK y/n");
                        userInput = Console.ReadLine();
                        if (userInput == "y")
                            discount = 0.15;
                    }


                }
            }
            Console.WriteLine($"Price of your ticket is {price = price-price * discount}");


            

        }
    }
}
