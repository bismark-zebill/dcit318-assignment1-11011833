// See https://aka.ms/new-console-template for more information
using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Triangle Type Identifier ===");

            Console.Write("Enter length of side 1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter length of side 2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter length of side 3: ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            // Check if the sides can form a triangle
            if (IsValidTriangle(side1, side2, side3))
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("The triangle is Equilateral.");
                }
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                {
                    Console.WriteLine("The triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is Scalene.");
                }
            }
            else
            {
                Console.WriteLine("The given sides do not form a valid triangle.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        //Function to check if the sides can form a triangle
        static bool IsValidTriangle(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
    }
}