using System;

namespace Task4MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Task 4
            //Create four methods for calculation sum, substract, multiplication and division of two numbers.
            //Create a function called calculator, that has three parameters.The first one is operator and then two numbers.
            //Depending on the value of the operator, call the corresponding function from the four ones from above.

            Console.WriteLine("Please input the first number:");
            bool success = int.TryParse(Console.ReadLine(), out int num1);

            Console.WriteLine("Please input the second number:");
            bool success2 = int.TryParse(Console.ReadLine(), out int num2);

            Console.WriteLine("Please input the Mathematical operation you want to perform: +,  -,  *, or /");
            string operation = Console.ReadLine();

            Calculator(operation, num1, num2);
            Calculator2(operation, num1, num2);


        }

        //So 1 metoda
        static void Calculator(string operation, int num1, int num2)
        {
            switch (operation)
            {
                case "+":
                    int result = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {result}");
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {result}");
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {result}");
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {result}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Can't divide by 0!");
                        break;
                    }

                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }

        }
        //So 4 metodi vo metod
        static int Sum(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {result}");
            return result;
        }
        static int Substract(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {result}");
            return result;
        }
        static int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {result}");
            return result;
        }
        static int Divide(int num1, int num2)
        {
            if (num2 != 0)
            {
                int result = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {result}");
                return result;
            }
            else
            {
                Console.WriteLine("You can divide by 0!");
                return -1; //Kako da se izvede da ne mora da mi vrati cel broj kako rezultat? Dali koga vekje funkcijata e od tip int, mora da vrati int kako rezultat, duri i ako ima pogreshen vnes? Vo sluchajov na primer, koga probuvame da delime so 0, kako rezultat da imam opisen string, kako toj na linija 94, bez kodot na linija 95?
            }
        }

        static void Calculator2(string operation, int num1, int num2)
        {
            switch(operation)
            { 
                case "+": 
                    Sum(num1, num2);
                    break;
                case "-":
                    Substract(num1, num2);
                    break;
                case "*":
                    Multiply(num1, num2);
                    break;
                case "/":
                    Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("You have entered a wrong input!");
                    break;                
            }
        }
    }
}
