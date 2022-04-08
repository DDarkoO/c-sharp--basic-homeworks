using System;
using System.Collections.Generic;
using System.Text;

namespace Task01ClassShape.Models
{
    public class Rectangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }

        public Rectangle()
        {
            
        }

        public Rectangle(double sideA, double sideB, string name, string color) : base()

        {
            SideA = sideA;
            SideB = sideB;
            Name = name;
            Color = color;            
        }

        public override void GetArea()
        {
            double area = SideA * SideB;
            Console.WriteLine($"The area of the {Name} with sides {SideA} and {SideB} is {area}");
        }

        public override void GetPerimeter()
        {
            double perimeter = 2 * (SideA + SideB);
            Console.WriteLine($"The perimeter of the {Name} with sides {SideA} and {SideB} is {perimeter}");
        }

    }
}
