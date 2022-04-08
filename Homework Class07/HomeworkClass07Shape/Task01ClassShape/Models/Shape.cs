using System;
using System.Collections.Generic;
using System.Text;

namespace Task01ClassShape.Models
{
    public class Shape
    {
        private string _name;
        private string _color;
        public int[] Position { get; set; }


        public Shape()
        {

        }

        public Shape(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.ToLower() == "rectangle" ||
                   value.ToLower() == "circle")
                {
                    _name = value;
                    Console.WriteLine($"The name of your geometrical shape is conventional name type. Your shape is {value}.");
                }
                else
                {
                    Console.WriteLine($"You have named your shape differently from the conventional name types and now poor {value} will get bullied at school.");
                    _name = value;
                }
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                if (value.ToLower() == "white" ||
                    value.ToLower() == "yellow" ||
                    value.ToLower() == "orange" ||
                    value.ToLower() == "red" ||
                    value.ToLower() == "magenta" ||
                    value.ToLower() == "green" ||
                    value.ToLower() == "blue" ||
                    value.ToLower() == "black")
                {
                    _color = value;
                    Console.WriteLine($" Its color is {value}");
                }
                else
                {
                    Console.WriteLine("You have entered an invalid color. Please pick one from the following: White, Yellow, Orange, Red, Magenta, Green, Blue or Black.");
                    _color = "Undefined color";
                    return;
                }
            }
        }

        public virtual void GetArea()
        {
            Console.WriteLine("There is no special implementation for area.");
        }


        public virtual void GetPerimeter()
        {
            Console.WriteLine("There is no special implementation for perimeter.");
        }


        public virtual void Move()
        {
            Console.WriteLine($"Please insert the value for X that defines the position of the {Name} on the X-axis.");
            bool successX = int.TryParse(Console.ReadLine(), out int positionX);

            Console.WriteLine($"Please insert the value for Y that defines the position of the {Name} on the Y-axis.");
            bool successY = int.TryParse(Console.ReadLine(), out int positionY);


            if (successX && successY)
            {
                int[] Position = new int[0];

                Array.Resize(ref Position, Position.Length + 2);

                Position[0] = positionX;
                Position[1] = positionY;

                int[] NewPosition = new int[2];

                NewPosition[0] = positionX + 5;
                NewPosition[1] = positionY + 5;

                Console.WriteLine($"Old coordinates: X = {Position[0]}, Y = {Position[1]}. New coordinates: X = {NewPosition[0]}, Y = {NewPosition[1]}");
            }
            else
            {
                if (!successX)
                {
                    Console.WriteLine("You have entered an invalid value for the position X.");
                }
                else
                {
                    Console.WriteLine("You have entered an invalid value for the position Y.");
                }
            }

            

        }


    }
}
