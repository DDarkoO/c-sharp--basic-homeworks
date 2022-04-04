using System;
using Task02ClassHuman.Models;

namespace Task02ClassHuman
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Task 2
            //Create a class Human
            //Add properties: FirstName, LastName, Age
            //Create a method called GetPersonStats that returns the full name of the human as well as their age
            //Create an object human by asking the user to fill the required information(take first name, last name and age from user input)
            //Call the GetPersonStats method and print the result in the console after the object is created

            Human human = new Human();

            Console.WriteLine("Enter the first name:");
            human.FirstName = Console.ReadLine();

            Console.WriteLine("Enter the last name:");
            human.LastName = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            human.Age = int.Parse(Console.ReadLine());

            Console.WriteLine(human.GetPersonStats());
        }
    }
}
