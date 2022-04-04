﻿using System;
using Task01ClassShape.Models;

namespace Task01ClassShape
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Create a class Shape that has:
            //Name
            //Color
            //Position, array of x and y coordinates(int[])
            //getArea - method that will only write in the console that there is no special implementation for area
            //getPerimeter - method that will only write in the console that there is no special implementation for perimeter* add method move that is shared among all instances and can be accessed through the class name. It updates the position of the input, by increasing the coordinates for 5.
            //*create a setter and getter for the color and name property.The setter/getter will log a corresponding message.The setter should do validation.

            //Add class Rectangle, that inherits from Shape.It should have properties sideA and sideB. Override the getArea and getPerimeter methods correspondingly for a rectangle.
            //Add class Circle, that inherits from Shape.It should have property radius. Override the getArea and getPerimeter methods correspondingly for a circle.
            //Test with few objects.

            Rectangle square = new Rectangle(5.0, 2.0, "aRectangle", "Red");

            Console.WriteLine("===============Get area");
            square.GetArea();
            Console.WriteLine("===============Get perimeter");
            square.GetPerimeter();
            Console.WriteLine("===============Moving the coordinates");
            square.Move();




            Console.WriteLine("===============Circle");
            Circle balloon = new Circle(10.0, "Balloon", "Magenta");

            Console.WriteLine("===============Get area");
            balloon.GetArea();
            Console.WriteLine("===============Get perimeter");
            balloon.GetPerimeter();
            Console.WriteLine("===============Moving the coordinates");
            balloon.Move();








        }
    }
}
