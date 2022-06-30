using System;
using System.Collections.Generic;

namespace DelegatesEx
{
    internal class Program
    {
        //define delegate that takes person obj and returns bool
        public delegate bool FilterDelegate(Person p);
        static void Main(string[] args)
        {
            //List<string> names = new List<string>()
            //{
            //    "Bob", "Mary", "Frank", "Joseph"
            //};
            //names.RemoveAll(Filter);

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            ////method called filter that takes string
            //static bool Filter(string s)
            //{
            //    //return whether the string s contains the letter a
            //    // the contains method will retgurn a bool which we will return as well
            //    return s.Contains("a");
            //}
            Person p1 = new Person() { name = "Bob", age = 41 };
            Person p2 = new Person() { name = "Joe", age = 25 };
            List<Person> people = new List<Person>() { p1, p2};

            //DisplayPeople("Adults", people, isAdult);

            //create new var called filter
            //asiggn anon method instead of defining one
            FilterDelegate filter = delegate (Person p)
            {
                return p.age >= 20;
            };
            DisplayPeople("Name", people, filter);

            DisplayPeople("All", people, delegate (Person p) { return true; });
        }
        // method to display list of people that passes filter
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            foreach (Person p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine($"{p.name} {p.age}");
                }

            }
        }

        static bool isMinor(Person p)
        {
            return p.age < 18;
        }

        static bool isAdult(Person p)
        {
            return p.age > 18;
        }
    }
}
