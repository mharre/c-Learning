using System;

namespace NullablesEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ? after data type to make nullable value type
            // either null or has a value
            int? num1 = null;
            int? num2 = 1336;

            double? num3 = new Double?();

            Console.WriteLine($"{num1}");
            Console.WriteLine($"{num2}");
            Console.WriteLine($"{num3}");

            bool? isMale = null;
            if (isMale == true)
            {
                Console.WriteLine("User is male.");
            } else if(isMale == false) {
                Console.WriteLine("User is female");
            } else
            {
                Console.WriteLine("No user found");
            }

            // conversion of nullable to non
            double? num4 = null;
            double? num5 = 3.3;
            num5 = num4 ?? 8.53;

            Console.WriteLine(num5);
        }
    }
}
