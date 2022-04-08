using System;
using System.Collections.Generic;
using System.Text;

namespace Task01ClassShape.Models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, string name, string color)
        {
            Radius = radius;
            Name = name;
            Color = color;
        }

        public override void GetArea()
        {
            double area = 2 * Radius * Math.PI;
            Console.WriteLine($"The area of the {Name} with radius {Radius} is {area}");
        }

        public override void GetPerimeter()
        {
            double perimeter = 2 * Radius * Math.PI;
            Console.WriteLine($"The perimeter of the {Name} with radius {Radius} is {perimeter}");
        }





    }
}
