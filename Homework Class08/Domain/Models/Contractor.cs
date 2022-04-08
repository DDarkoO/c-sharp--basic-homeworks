using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor(string firstName, string lastName, double workHours, int payPerHour): base(firstName, lastName)  
        {          
            WorkHours = workHours;
            PayPerHour = payPerHour;
        }

      

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }

        public Manager CurrentPosition()
        {
            return Responsible;
        }

    }
}
