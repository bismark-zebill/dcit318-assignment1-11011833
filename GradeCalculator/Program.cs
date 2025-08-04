// See https://aka.ms/new-console-template for more information
using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Grade Calculator===");
            Console.Write("Enter your grade (0 - 100): ");

            string input = Console.ReadLine();
            int grade;

            if (int.TryParse(input, out grade))
            {
                if (grade >= 0 && grade <= 100)
                {
                    string letterGrade;

                    if (grade >= 90)
                        letterGrade = "A";
                    else if (grade >= 80)
                        letterGrade = "B";
                    else if (grade >= 70)
                        letterGrade = "C";
                    else if (grade >= 60)
                        letterGrade = "D";
                    else
                        letterGrade = "F";

                    Console.WriteLine($"Your letter grade is: {letterGrade}");
                }
                else
                {
                    Console.WriteLine("Error: Grade must be between 0 and 100.");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a numeric grade.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
