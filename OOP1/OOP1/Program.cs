using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3,4,5);

            box.DisplayInfo();
            Console.WriteLine(box.Volume);
        }
    }
}
