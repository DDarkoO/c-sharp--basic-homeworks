using System;
using Domain.Enums;
using Domain.Models;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee()
            //{
            //    FirstName = "Marko",
            //    LastName = "Markovski",
            //    Role = RoleEnum.Other
            //};
            //employee.PrintInfo();

            //SalesPerson salesPerson = new SalesPerson("Bob", "Bobsky");
            //salesPerson.AddSuccessRevenue(300);
            //GetSalary from SalesPerson is called
            //Console.WriteLine(salesPerson.GetSalary());

            //Manager manager = new Manager("Bill", "Billsky", 700);
            //GetSalary from Manager is called
            //Console.WriteLine(manager.GetSalary());
            //manager.AddBonus(200);
            //manager.AddBonus(100);
            //GetSalary from Manager is called
            //Console.WriteLine(manager.GetSalary());




            //TASK 1 + TASK 2 HOMEWORK

            Contractor contractorOne = new Contractor("Gandalf", "The Grey", 40, 10);
            Contractor contractorTwo = new Contractor("Boromir", "The Weak", 40, 10);

            Manager managerOne = new Manager("Saruman", "The White", 10000);
            Manager managerTwo = new Manager("Sauron", "The Blind", 20000);

            SalesPerson storySeller = new SalesPerson("Frodo", "Baggins");


            Employee[] fellowship = new Employee[] { contractorOne, contractorTwo, managerOne, managerTwo, storySeller };
            
            
            CEO trueKing = new CEO("Aragorn", "The True King", 50000, 300, fellowship, RoleEnum.CEO);

            trueKing.AddSharesPrice(1000);            
            trueKing.PrintInfo();
            trueKing.GetSalary();
            trueKing.PrintEmployees();            
            



        }
    }
}
