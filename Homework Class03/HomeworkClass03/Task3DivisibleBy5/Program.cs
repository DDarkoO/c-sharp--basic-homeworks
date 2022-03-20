using System;

namespace Task3DivisibleBy5
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Task 3
            //Ask the user to enter a number as an input.Print all the numbers except the numbers divisible by 5.When you come to 80, the limit is reached.

            Console.WriteLine("Enter a whole number:");
            bool success = int.TryParse(Console.ReadLine(), out int num);

            if (success)
            {
                for (int i = 1; i <= num; i++)
                {
                    if (i % 5 == 0)
                    {
                        continue;
                    }
                    else if (i >= 80)
                    {
                        Console.WriteLine("You have reached the limit.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }                                        
                }
                
            }
            else
            {
                Console.WriteLine("You have entered a wrong input, please try again.");
            }
        }
    }
}
