using System;

namespace Struct
{
    internal class Program
    {
        //struct has to have a value - classes do not
        //cannot make default constructors
        //do not support inheritance
        //CAN have defined constructors
        //works by value not reference

        struct Game
        {
            public string name;
            public string developer;
            public string rating;
            public string releaseDate;

            public Game(string name, string developer, string rating, string releaseDate)
            {
                this.name = name;
                this.developer = developer;
                this.rating = rating;
                this.releaseDate = releaseDate;
            }

            public void Display()
            {

                Console.WriteLine(name);
            }
        }
        static void Main(string[] args)
        {
            Game game1;

            game1.name = "Cool Game";
            game1.developer = "Good";
            game1.rating = "Bad";
            game1.releaseDate = "Never";

            game1.Display();

        }
    }
}
