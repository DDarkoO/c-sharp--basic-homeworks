using System;

namespace Task1AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Task 1
            //Make a method called AgeCalculator
            //The method will have one input parameter, your birthday date
            //The method should return your age
            //Show the age of a user after he inputs a date
            //Note: take into consideration if the birthday is today, after or before today                    

            AgeCalculator();
            AgeCalculator();
            AgeCalculator();
            AgeCalculator();

        }

        static void AgeCalculator()
        {
            Console.WriteLine("Please input your birthday date in the followin format: year, month, day (all 3 with whole numbers)");
            
            string bDayString = (Console.ReadLine());

            if (DateTime.TryParse(bDayString, out DateTime birthDay))
            {                
                DateTime currentDate = DateTime.Now;
                TimeSpan days = currentDate.Subtract(birthDay);
                int currentAge = int.Parse(days.Days.ToString());
                                
                if (currentDate.Month == birthDay.Month && currentDate.Day == birthDay.Day)
                {
                    Console.WriteLine($"Happy birthday! You are {(currentAge + currentAge / 1460) / 365} years old.");
                    return;
                }
                else if (currentDate.Month == birthDay.Month && currentDate.Day - 1 == birthDay.Day)
                {
                    Console.WriteLine($"You are {(currentAge + currentAge / 1460) / 365} years old. You are still dizzy from your birthday party yesterday.");                  
                }
                else if (currentDate.Month == birthDay.Month && currentDate.Day + 1 == birthDay.Day)
                {
                    Console.WriteLine($"Are you ready for your birthday party tomorrow? You will be {(currentAge + currentAge / 1460) / 365} years old tomorrow.");
                    Console.WriteLine("");
                }
                else 
                { 
                Console.WriteLine($"You are {(currentAge + currentAge / 1460) / 365} years old.");
                }

            }
            else
            {
                Console.WriteLine("You have entered wrong date format. Please try again");
            }                   







        }
    }
}
