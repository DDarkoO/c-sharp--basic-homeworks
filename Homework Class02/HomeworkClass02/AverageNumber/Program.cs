using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Task 2
            //Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

            //Test Data:
            //Enter the First number: 10
            //Enter the Second number: 15
            //Enter the third number: 20
            //Enter the four number: 30
            //Expected Output:
            //The average of 10, 15, 20 and 30 is: 18

            int a, b, c, d;
            double result;

            Console.WriteLine("Enter the First number");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second number");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Third number");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Fourth number");
            d = int.Parse(Console.ReadLine());

            result = ((double)a + b + c + d) / 4;

            Console.WriteLine($"The average of {a}, {b}, {c} and {d} is: {result}");


        }
    }
}
