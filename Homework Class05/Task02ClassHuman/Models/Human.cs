using System;
using System.Collections.Generic;
using System.Text;

namespace Task02ClassHuman.Models
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Human()
        {

        }

        public string GetPersonStats()
        {
            return $"Hello {FirstName} { LastName}, you are {Age} years old.";
        }



    }
}
