using System;
using System.Collections;

namespace Hashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            Student stud1 = new Student(1, "Bob", 30);
            Student stud2 = new Student(2, "Jason", 45);

            table.Add(stud1.id, stud1);
            table.Add(stud2.id, stud2);

            Student storedStudent1 = (Student)table[stud1.id];

            //foreach (DictionaryEntry entry in table)
            //{
            //    Student temp = (Student)entry.Value;
            //    Console.WriteLine($"{temp.id}");
            //    Console.WriteLine($"{temp.name}");
            //    Console.WriteLine($"{temp.GPA}");
            //    Console.WriteLine("--------------");
            //}

            //simplier for each loop for hash tables
            foreach (Student value in table.Values)
            {
                Console.WriteLine($"{value.id}");
                Console.WriteLine($"{value.name}");
                Console.WriteLine($"{value.GPA}");
                Console.WriteLine("--------------");

            }
        }

        class Student
        {
            //property called Id
            public int id { get; set; }
            //property called name
            public string name { get; set; }

            public float GPA { get; set; }
            
            // constructor
            public Student(int id, string name, float GPA)
            {
                this.id = id;
                this.name = name;
                this. GPA = GPA;
            }
        }
    }
}
