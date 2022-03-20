using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Task 2
            //Make a console application called SumOfEven. Inside it create an array of 6 integers.Find and print the sum of the even numbers from the array:

            //Test Data:
            //Enter integer no.1:
            //4
            //Enter integer no.1:
            //3
            //Enter integer no.1:
            //7
            //Enter integer no.1:
            //3
            //Enter integer no.1:
            //2
            //Enter integer no.1:
            //8
            //Expected Output:
            //The result is: 14

            int[] intArray = { 4, 3, 7, 3, 2, 8 };
            //Console.WriteLine(intArray);
            int result = 0;

            for (int i = 0; i < intArray.Length; i++)
            {                
                if( intArray[i] % 2 == 0)
                {
                    result += intArray[i];
                }
            }
            Console.WriteLine($"The sum of the even numbers in the array is: {result}");
        }
    }
}
