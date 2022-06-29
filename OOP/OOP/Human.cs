using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Human
    {
        // member variable
        public string firstName;
        public string lastName;

        public Human()
        {
            Console.WriteLine("Created");
        }


        // paramitized constructor
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // member
        public void IntroduceMyself()
        {
            Console.WriteLine($"My name is {firstName} {lastName}");
        }
    }
}
