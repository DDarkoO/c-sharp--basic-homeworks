using System;

namespace FindStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Task 1
            //Create new console application “FindStatistics”. Input 2 numbers.If the two of them are even, print their sum, if one of them is odd, print their difference, if the two off them are odd, multiply them. Don't print just the result, but also the whole operation. Treat zero as even. Please find example below:

            //Test Data:
            //Input the First Number: 8
            //Input the Second Number: 5
            //Expected Output:
            //One of the numbers is odd.The operation and result are 8 - 5 = 3.

            Console.WriteLine("Input the First number:");
            bool success1 = int.TryParse(Console.ReadLine(), out int firstNumber);

            Console.WriteLine("Input the Second number:");
            bool success2 = int.TryParse(Console.ReadLine(), out int secondNumber);

            int result;

            if (success1 && success2)
            {
                if (firstNumber % 2 == 0 && secondNumber % 2 == 0)
                {
                    result = firstNumber + secondNumber;
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
                }
                else if ((firstNumber % 2 != 0 && secondNumber % 2 == 0) || (firstNumber % 2 == 0 && secondNumber % 2 != 0))
                {
                    result = firstNumber - secondNumber;
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
                }
                else if (firstNumber % 2 != 0 && secondNumber % 2 != 0)
                {
                    result = firstNumber * secondNumber;
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
                }

            }

            else
            {
                if (!success1)
                {
                    Console.WriteLine("First input is incorrect!");
                }
                else
                {
                    Console.WriteLine("Second input is incorrect!");
                }
            }
        }
    }
}
