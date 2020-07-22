using System;

namespace Lab3Cellini
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeat;
            repeat = "y";

            Console.WriteLine("Please enter your first name:");
            string username;
            username = Console.ReadLine();

            while (repeat == "y")
            {
                Console.WriteLine("Enter a number between 1 and 100:");
                string input;
                input = Console.ReadLine();
                int num = int.Parse(input);

                if(num <=0 || num >= 101)
                {
                    Console.WriteLine("Please try entering a positive integer between 1 and 100, " + username + ".");
                }

                if (num % 2 == 0 && num >= 1 && num < 25)
                {
                    Console.WriteLine("Even and less than 25");
                }
                else if (num % 2 != 0)
                {
                    Console.WriteLine(num + " and odd");
                }
                else if (num % 2 == 0 && num >= 26 && num <= 60)
                {
                    Console.WriteLine("Even");
                }
                else if (num > 60 && num % 2 == 0)
                {
                    Console.WriteLine(num + " and even");
                }

                Console.WriteLine("Would you like to continue, " + username + "? (y/n)");
                repeat = Console.ReadLine();
            }

            Console.WriteLine("Goodbye, " + username + "!");

        }
    }
}
