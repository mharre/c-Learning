using System;

namespace tryAndCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter a number: ");
            //string input = Console.ReadLine();     

            //try
            //{
            //    int userInput = int.Parse(input);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Format exception, please enter a correct value next time");
            //} catch (OverflowException)
            //{
            //    Console.WriteLine("Number is too long");
            //} finally
            //{
            //    Console.WriteLine("This is called no matter what");
            //}

            //Check(3);
            //Check(4);

            int age = 25;

            switch (age)
            {
                case 15:
                    Console.WriteLine("too young to enter");
                    break;
                case 25:
                    Console.WriteLine("Good!");
                    break;
                default:
                    Console.WriteLine("YOU SUCK");
                    break;
            }
        }

        public static void Check(int num1)
        {
            if (num1 % 2 == 0)
            {
                Console.WriteLine("Even");
            } else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
