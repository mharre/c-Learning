using System;

namespace datetimeEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(1993, 2, 14);

            Console.WriteLine(dt);

            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now);

            DateTime tomorrow = getTomorrow();
            Console.WriteLine(tomorrow);
            Console.WriteLine(getFirstDayOfYear(1999));

            DateTime now = DateTime.Now;
            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);
            Console.WriteLine(now.Second);

            Console.WriteLine("Enter a date in yyyy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out dt))
            {
                Console.WriteLine(dt);
                TimeSpan daysPassed = now.Subtract(dt);
                Console.WriteLine(daysPassed.Days);
            } else
            {
                Console.WriteLine("wrong input");
            }

        }

        static DateTime getTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime getFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
