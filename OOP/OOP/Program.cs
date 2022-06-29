using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // right click on OOP to the right, add new item, class and give name

            Human matthew = new Human("Matthew", "Michael");
            matthew.IntroduceMyself();

            Human test = new Human();
        }
    }
}
