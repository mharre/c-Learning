using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

             for(start value; condition; increment;(
            {
                 body
            }

            count = 0;
            while (condition)
            {
                 body
                 count ++
            }

            count = 0;
            do 
            {
                 execute code
                 count ++
            } while(condition)
            will run atleast once

             forEach  = for arrays

             */

            for (int counter = 0; counter < 50; counter +=5)
            {
                Console.WriteLine(counter);
            }
        }
    }
}
