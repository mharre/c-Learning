using System;
using System.Collections.Generic;
namespace Dict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary <Type Key, Type Value>
            // generic way

            Dictionary<int, string> myDict = new Dictionary<int, string>()
            {
                {1, "one" },
                {2, "two" },
                {3, "three" },
            };
        }
    }
}
