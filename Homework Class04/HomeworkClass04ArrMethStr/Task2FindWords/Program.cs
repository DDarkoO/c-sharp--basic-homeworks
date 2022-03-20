using System;

namespace Task2FindWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Task 2
            //Take a sentence as input and find its words.

            Console.WriteLine("Please input a sentence with at least 5 words!");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(" ");

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

        }
    }
}
