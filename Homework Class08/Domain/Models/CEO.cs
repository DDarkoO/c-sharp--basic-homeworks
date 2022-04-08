using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class CEO :Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double _SharesPrice { get; set; }


        public CEO(string firstName, string lastName, double salary, int shares, Employee[] employees, RoleEnum role)
        {
            FirstName = firstName;
            LastName = lastName;    
            Salary = salary;
            Shares = shares;
            Employees = employees;
            Role = role;
        }

        public double AddSharesPrice(double quantity)
        {
            _SharesPrice += quantity;
            return _SharesPrice;
        }


        public List<Employee> PrintEmployees()
        {
            Console.WriteLine("The following employees are under CEO's command:");

            List<Employee> employees = new List<Employee>();

            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
                employees.Add(employee);
            }

            return employees;
        }

        public override double GetSalary()
        {
            Salary += Shares * _SharesPrice;
            Console.WriteLine($"The CEO's monthly salary is {Salary} $.");
            return Salary;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Role}:");
            Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}, Salary: {Salary}$.");
        }

    }
}
