using System;

namespace Task5Neighbouring3s
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Task 5
            //Create an array of integers.Get the number of elements and the values of the elements from input.
            //Find how many times there are two 3 next to each other.
            //Example:
            //            Enter number of elements: 7
            //Enter first element: 9
            //Enter second element: 3
            //Enter first element: 3
            //Enter first element: 4
            //Enter first element: 3
            //Enter first element: 3
            //Enter first element: 3
            //Three times there are threes next to each other.

            Console.WriteLine("How many elements would you like your array of whole numbers to have?");
            bool success = int.TryParse(Console.ReadLine(), out int lengthOfArray);

            if (!success)
            {
                Console.WriteLine("Wrong Input!");
            }
            else
            {
                int[] intArray = new int[lengthOfArray];

                for (int i = 0; i < lengthOfArray; i++)
                {
                    Console.WriteLine($"Enter the number at position {i + 1}:");
                    bool success2 = int.TryParse(Console.ReadLine(), out int holder);

                    if (success2)
                    {
                        intArray[i] = holder;
                    }
                    else
                    {
                        Console.WriteLine("You have entered a wrong input!");
                        break;
                    }
                }

                int counter = 0;

                for (int i = 0; i < intArray.Length - 1; i++)
                {
                    if (intArray[i] == 3 && intArray[i + 1] == 3)
                    {
                        counter++;
                    }
                }

                Console.WriteLine($"There are {counter} instances of threes next to each other");
            }
        }
    }
}
