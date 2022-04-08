using System;
using Task03Animal.Models;
using Task03Animal.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Task03Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Task 3
            //Create a class Animal. Each Animal has name, color, age and Gender.Use enum for Gender.

            //Find the names of all the animals aged 5 or more
            //Find all the names of the animals that start with 'A'
            //Find all male, brown animals
            //Find the first animal whose name is longer than 10 characters

            Animal dog = new Animal("Majlo", "White", 15, GenderEnum.Male);
            Animal crocodile = new Animal("Toothless", "Deep Dark Green", 15, GenderEnum.Male);
            Animal zebra = new Animal("Anya", "Red", 4, GenderEnum.Female);
            Animal antilope = new Animal("Lightning Bolt", "Brown", 6, GenderEnum.Female);
            Animal lion = new Animal("Asimba", "Brown", 8, GenderEnum.Male);
            Animal tiger = new Animal("Shir-Kan Junior", "Brown", 8, GenderEnum.Male);
            Animal cow = new Animal("Milka", "Purple", 3, GenderEnum.Female);
            Animal elephant = new Animal("Dumbo Slim", "Gray", 75, GenderEnum.Male);

            List<Animal> ourZoo = new List<Animal>() { dog, crocodile, zebra, antilope, lion, tiger, cow, elephant };

            //List<Animal> ourZoo = new List<Animal>()
            //{
            //    new Animal("Majlo", "White", 15, GenderEnum.Male),
            //    new Animal("Majlo", "White", 15, GenderEnum.Male),
            //    new Animal("Toothless", "Deep Dark Green", 15, GenderEnum.Male),
            //    new Animal("Anya", "Red", 4, GenderEnum.Female),
            //    new Animal("Lightning Bolt", "Brown", 6, GenderEnum.Female),
            //    new Animal("Asimba", "Brown", 8, GenderEnum.Male),
            //    new Animal("Shir-Kan Junior", "Brown", 8, GenderEnum.Male),
            //    new Animal("Milka", "Purple", 3, GenderEnum.Female),
            //    new Animal("Dumbo Slim", "Gray", 75, GenderEnum.Male)
            //};

            Console.WriteLine("======= Animals older than 5 ========");
            List<Animal> olderThanFive = ourZoo.Where(d => d.Age > 5).ToList();

            foreach (Animal animal in olderThanFive)
            {
                Console.WriteLine(animal.Name);
            }



            Console.WriteLine("======= Animals whose names start with 'A' ========");
            List<Animal> nameStartsWithA = ourZoo.Where(d => d.Name.StartsWith("A")).ToList();

            foreach (Animal animal in nameStartsWithA)
            {
                Console.WriteLine(animal.Name);
            }



            Console.WriteLine("======= Male, brown animals ========");
            List<Animal> maleBrownAnimals = ourZoo.Where(d => d.Color == "Brown" && d.Gender == GenderEnum.Male).ToList();

            foreach (Animal animal in maleBrownAnimals)
            {
                Console.WriteLine(animal.Name);
            }



            Console.WriteLine("======= First animal with name longer than 10 characters ========");
            Animal firstAnimalNameLongerThanTen = ourZoo.FirstOrDefault(d => d.Name.Length > 10);

            Console.WriteLine(firstAnimalNameLongerThanTen.Name);

        }
    }
}
