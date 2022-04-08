using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task01QUEUE
{
    class Program
    {
        static void Main(string[] args)
        {
                                                                                    //            Task 1
                                                                                    //Give the user an option to input 5 numbers
                                                                                    //Store all numbers in a QUEUE
                                                                                    //When the user is done adding numbers print the number in the order that the user entered them from the QUEUE
            Queue<int> fiveNumbers = new Queue<int>();

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Enter a number at position {i}:");
                bool success = int.TryParse(Console.ReadLine(), out int passed);

                // 1)
                if (success)
                {
                    fiveNumbers.Enqueue(passed);
                }
                else
                {
                    Console.WriteLine("You have entered an invalid number, please try again.");
                    break;
                }

                // 2)
                //while (!success)
                //{
                //    Console.WriteLine("You have entered an invalid number, please try again.");
                //    break;
                //}

                //while (!int.TryParse(Console.ReadLine(), out int passFail))
                //{
                //while (true)
                //{
                //Console.WriteLine("You have entered an invalid number, please try again.");
                //}
                //}

                //int passSuccess = int.Parse(Console.ReadLine());
                //int passSuccess = int.Parse(Console.ReadLine());
                //fiveNumbers.Enqueue(passed);                

            }

            //Queue<int> reversedFiveNumbers = new Queue<int>(fiveNumbers.Reverse()); //just a trial

            int counter = 1;

            foreach (int number in fiveNumbers)
            {
                Console.WriteLine($"Number at position {counter}: {number}");
                counter++;
            }

            //foreach (int number in reversedFiveNumbers) //just a trial
            //{
            //    Console.WriteLine($"Number at position {counter}: {number}");
            //    counter++;
            //}

        }
    }
}
