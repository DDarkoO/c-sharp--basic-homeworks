using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Task 3:
            //Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value. Please find example below:

            //Test Data:
            //Input the First Number: 5
            //Input the Second Number: 8
            //Expected Output:
            //After Swapping:
            //First Number: 8
            //Second Number: 5

            Console.WriteLine("Input the First Number:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the First Number:");
            int y = int.Parse(Console.ReadLine());

            int xSwap = y;
            int ySwap = x;
            x = xSwap;
            y = ySwap;

            Console.WriteLine($"After swapping: First number = {x}; Second number = {y}");

        }
    }
}
