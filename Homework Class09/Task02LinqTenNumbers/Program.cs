using System;
using System.Collections.Generic;
using System.Linq;

namespace Task02LinqTenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Task 2
            //Create a list of ten numbers.
            //Use LINQ to select in a list of the squares of all the numbers in the list from above.

            List<double> tenNumbers = new List<double>();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Please enter number {i}: ");
                bool success = double.TryParse(Console.ReadLine(), out double number);
                if (!success)
                {
                    Console.WriteLine("Wrong input, please restart the console and try again!");
                    break;
                }
                else
                {
                    tenNumbers.Add(number);
                }
            }

            List<double> squares = tenNumbers.Select(s => (s*s)).ToList();

            Console.WriteLine("List of the squares of your numbers:");

            foreach (double square in squares)
            {
                Console.WriteLine(square);
            }


        }
    }
}
