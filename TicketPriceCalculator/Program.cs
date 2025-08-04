// See https://aka.ms/new-console-template for more information
using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Ticket Price Calculator ===");
            Console.Write("Enter your age: ");

            // Read user input
            string input = Console.ReadLine();
            int age;

            // Validate input
            if (int.TryParse(input, out age))
            {
                if (age >= 0)
                {
                    double ticketPrice;

                    // Check age group for discount
                    if (age <= 12 || age >= 65)
                        ticketPrice = 7.0;
                    else
                        ticketPrice = 10.0;

                    Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
                }
                else
                {
                    Console.WriteLine("Error: Age cannot be negative.");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
