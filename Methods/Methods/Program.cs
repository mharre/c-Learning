using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////// Syntax
            /*
             <Access Specificer><Return Type><Method Name>(Param list)
            {
                Method Body
            }
             */
            //WriteSomething();
            //WriteSomethingSpecific("test");
            //Console.WriteLine(Add(1, 2));
            //Console.WriteLine(Add(Add(1,2), Add(1,2)));
            //GreetFriend("Andrew");
            Console.WriteLine(Add());
        }

        // access modifier (static) return type methond name
        public static void WriteSomething()
        {
            Console.WriteLine("called from a method");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        public static int Add()
        {
            Console.WriteLine("Please enter a number to be added: ");
            string num1 = Console.ReadLine();

            Console.WriteLine("Please enter a second number to be added: ");
            string num2 = Console.ReadLine();

            int result = Int32.Parse(num1) + Int32.Parse(num2);
            return result;
        }

        public static void GreetFriend(string friend)
        {
            Console.WriteLine($"Hello {friend}");
            Console.WriteLine(friend.Length);
        }
    }
}
