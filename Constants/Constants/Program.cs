using System;

namespace Constants
{
    internal class Program
    {
        // constants are generally fields (outside of methods)
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const string myBirthday = "02/14/1993";

        static void Main(string[] args)
        {
            Console.WriteLine($"Birthday is {myBirthday}");
        }
    }
}
