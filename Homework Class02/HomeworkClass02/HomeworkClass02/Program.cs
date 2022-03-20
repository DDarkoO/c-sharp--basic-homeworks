using System;

namespace HomeworkClass02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 01");

            //            Task 1
            //Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done( +, - , * , / ). Then it returns the result.

            //Test Data:
            //Enter the First number: 10
            //Enter the Second number: 15
            //Enter the Operation: +
            //Expected Output:
            //            The result is: 25

            
            int x,y,result;

            Console.WriteLine("Enter the first number");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the mathematical operation you want to be used - ( +, - , * , / )");
            string operationInput = Console.ReadLine();

            switch (operationInput)
            {
                case "+":
                    result = x + y;
                    Console.WriteLine($"{x} + {y} = {result}");
                    break;
                case "-":
                    result = x - y;
                    Console.WriteLine($"{x} - {y} = {result}");
                    break;
                case "*":
                    result = x * y;
                    Console.WriteLine($"{x} * {y} = {result}");
                    break;
                case "/":
                    result = x / y;
                    Console.WriteLine($"{x} / {y} = {result}");
                    break;
                default:
                    Console.WriteLine("You have entered a wrong mathematical operation");
                    break;
            }

            


        }
    }
}
