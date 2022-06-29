using System;

namespace ternary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // condition ? first_expression : second_expressionl
            // condition has to be either true or false
            // the conditional operator is right - associative
            // the expression a ? b: c? d:e
            // is evaluated as a? b : (c ? d: e),
            // conditional operator cannot be overloaded

              
            int temp = -5;
            string stateOfMatter;
            /*
            if (temp < 0)
                stateOfMatter = "solid";
            else
                stateOfMatter = "liquid";
            */

            stateOfMatter = temp < 0 ? "solid" : "liquid";
            Console.WriteLine($"State of matter is {stateOfMatter}");

        }
    }
}
