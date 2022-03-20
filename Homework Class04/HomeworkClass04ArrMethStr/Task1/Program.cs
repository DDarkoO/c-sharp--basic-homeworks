using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Task 1
            //Take one string from the input and print its last 5 characters.

            Console.WriteLine("Please type a string as per your choice!");
            string input = Console.ReadLine();

            // As full string
            if (input.Length < 5)
            {
                Console.WriteLine("Your string is too short, it needs to have at least 5 characters!");
            }
            else
            {
                string characters = input.Substring(input.Length - 5);
                Console.WriteLine(characters);
            }

            // In array
            string[] characters2 = new string[5];

            if (input.Length < 5)
            {
                Console.WriteLine("Your string is too short, it needs to have at least 5 characters!");
            }
            else
            {
                for (int i = input.Length; i > input.Length - 5; i--)
                {
                    characters2[input.Length - i] = input.Substring(input.Length - 1 - (input.Length - i), 1); 
                }

                Array.Reverse(characters2);

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Character {i}: {characters2[i]}");
                }
            }




        }
    }
}
