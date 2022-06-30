using System;

namespace lambdaEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declartion =>
            // expression lambda
            // (input-parameters) => expression
            // statement lambda
            // (input-param) => { sequence }
            /* 
             Statement:
             DisplayPeople("age with keyword", people, (p) => 
            {
                if (p.name.Contains("A")
                {
                    return true;
                }
                return false;
            });

            Expression:
            DisplayPeople("age=25", people, (p) => p.age == 25);
             */
        }
    }
}
