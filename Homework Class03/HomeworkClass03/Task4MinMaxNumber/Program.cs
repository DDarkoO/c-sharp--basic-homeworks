using System;

namespace Task4MinMaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Task 4
            //Make a new console application.
            //Create an array of 10 whole numbers(integers).
            //Find the minimum and maximum and print them in the console.

            int[] intArray = { 100, -6, 56, -2345, 23334, 0, -35, 7, 10, -5000, -7000 };

            int min = intArray[0];
            int max = intArray[0];

            for (int i = 0; i <= intArray.Length; i++)
            {
                if ( i == intArray.Length )
                {
                    Console.WriteLine($"The lowest number is: {min} and the highest one is {max}");
                    break;
                }

                if (intArray[i] > max)
                {
                    max = intArray[i];
                }

                if (intArray[i] < min)
                {
                    min = intArray[i];
                }
                
            }

            //double zero = 0.0;

            //double min = 1 / zero;
            //double max = -1 / zero;

            //int minNew;
            //int maxNew;

            //for (int i = 0; i <= intArray.Length; i++)
            //{   
            //    if (i == intArray.Length)
            //    {
            //        Console.WriteLine($"The lowest number is: {minNew} and the highest one is {maxNew}");
            //        break;
            //    }
            //    if (intArray[i] < min)
            //    {
            //        minNew = intArray[i];
            //    }
            //    if (intArray[i] > max)
            //    {
            //        maxNew = intArray[i];
            //    }                                
            //}


        }
    }
}
