using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace membersFinalizers
{
    internal class Class1
    {
        // member -p rivate
        private string memberName;
        private string jobTitle;
        private int salary = 2000;

        // m,ember public
        public int age;

        // member properties - props start with a capital letter

        public string JobTitle {
            get 
            { 
                return jobTitle;
            } set 
            {
                jobTitle = value;
            } 
        }

        //public member method, called from other classes
        public void Introduce(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            } else
            {
                Console.WriteLine($"My name is {memberName}, my job is {jobTitle}");
            }

        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine($"My salary is {salary}");
        }

        //members constructor
        public Class1()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";

            Console.WriteLine("Object Creatred");
        }

        // m,ember fionalizer - destructor
        ~Class1()
        {
            // cleanup statements - whenever deleted, closed or runs out of scope this activates etc - not common to use
            Console.WriteLine("Deconstruction of object");
        }
    }
}
