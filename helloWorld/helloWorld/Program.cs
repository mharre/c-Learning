using System;

namespace helloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 13;
            //int num2 = 25;

            //float num2 = 3.3f;
            //float num3 = 4.4f;

            //Console.WriteLine(num1);
            //Console.WriteLine(num2/num3);
            //Console.WriteLine(Math.Floor(num2/num3));

            //string test = "test";
            //Console.WriteLine(test.IndexOf('e'));
            //test.Split('s');
            //Console.WriteLine(test);

            //Console.Write("Enter a string and press enter:");
            //string readinput = Console.ReadLine();
            //Console.WriteLine("You have entered {0}",readinput);

            //Console.Write("Enter a string and press enter: ");
            //int asciiValue = Console.Read();
            //Console.WriteLine("ASCII value is {0}",asciiValue);

            ////////////// EXPLICIT VS IMPLICIT CONVERSION
            //double myDouble = 13.37;
            //int myInt;
            //myInt = (int)myDouble;
            //Console.WriteLine(myInt);

            //float myFloat = 13.37f;
            //double myNewDouble = myFloat;

            ////////////// TYPE CONVERSTION
            //string myString = myDouble.ToString();

            ////////////// STRING TO INT
            //string myString = "15";
            //string mySecondString = "13";
            //string result = myString + mySecondString;
            //Console.WriteLine(result);

            //int num1 = Int32.Parse(myString);
            //int num2 = Int32.Parse(mySecondString);
            //int newResult = num1 + num2;
            //Console.WriteLine(newResult);

            ////////////// CONVERSION

            //string stringForFloat = "0.85"; // datatype should be float
            //string stringForInt = "12345"; // datatype should be int

            //float f = float.Parse(stringForFloat);
            //int i = Int32.Parse(stringForInt);
            //Console.WriteLine("{0}, {1}", f, i);

            ////////////// STRING INTERPOLATION
            // allows $ at start and then use varName
            //string name = "Bob";
            //Console.WriteLine($"{name}");

            ///////////// Verbatim Strings
            // takes string literally
            // good for writing absolute paths

            ////////////// STRING METHODS
            // SubString(int32)
            // ToLower(), ToUpper()
            // Trim() - get rid of trailing white space
            // IndexOf()
            //string test = "test";
            //Console.WriteLine(test.Substring(1));
            //Console.WriteLine(test.IndexOf('e'));

            //string test = "";
            //Console.Write("Enter your first name: ");
            //test = Console.ReadLine();
            //Console.Write("Enter a char to search: ");
            //string userChar = Console.ReadLine();
            //int i = test.IndexOf(userChar);
            //Console.WriteLine($"Index is: {i}");
            //Console.WriteLine("Enter your last name: ");
            //string test1 = Console.ReadLine();
            //Console.WriteLine($"{test} {test1}");

            // CONSTANTS - IMMUTABLE VALUES!
        }
    }
}