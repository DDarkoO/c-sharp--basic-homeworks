using System;

namespace Task3DigitsSum
{
    class Program
    {
        static void Main(string[] args)
        {
                //            Task 3
                //Create a function that takes a number as input.This method should return the sum of the digits in the number.
            
            //Console.WriteLine("Please input any whole number.");

            SumOfDigits(565); 
            SumOfDigits(155412);
            SumOfDigits(99988979);
            SumOfDigits(2138551561);
            SumOfDigits(6);

            // So kakva sintaksa argumentot da se vnese od strana na user-ot, a pritoa da se proveri dali inputot e validen? Prashuvam za povekjekratno povikuvanje na metodot edno pod drugo, za edno povikuvanje mislam deka bi go zachuvale vnesot od korisnikot vo promenliva koja bi ja validirale i bi ja iskoristile kako argument vo metodot (neshto slichno kako Task 4, prvoto reshenie
        }
        
        static int SumOfDigits(int input)
        {
            //bool success = int.TryParse(Console.ReadLine(), out int number);            
            //bool success = int.TryParse(input, out int number);
            // Sintaksata so success i dopolnitelniot if podolu gi ostaviv zakomentirani, probuvav da napravam interna validacija vo metodot za tipot na promenlivata, povrzano so prashanjeto od linija 19 pogore. Jasno mi e deka ne funkcionira zatoa shto ne mozhe da parsirame vekje potvrden int, ama gi ostaviv chisto za da se vidi vo koja nasoka probuvav da dojdam do nekakva validacija
            
            int[] digits = new int[0];
            int helper = input;
            int sum = 0;

            //if (success)
            //{
            if (input < 10)
                {
                    Console.WriteLine($"The sum of the digits of the number {input} is: {input}!");
                    return input;
                }
                else
                {                    
                    while (helper > 0)
                    {
                        for (int i = 0; i < input.ToString().Length; i++)
                        {                        
                        int helper2 = helper % 10;
                        helper /= 10;
                        Array.Resize(ref digits, i+1);
                        digits[i] = helper2;                        
                        }

                    }                                                  
                }
                            
                for (int i = 0; i < digits.Length; i++)
                {
                    sum += digits[i];
                }

                Console.WriteLine($"The sum of the separate digits of the number {input} is: {sum}!");
                return sum;
                
                                
            //}
            //else
            //{                
            //    return -1;
            //}               


        }
    }
}
