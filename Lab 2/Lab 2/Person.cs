using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Person
    {
        public bool isMarried;

        public int age;
        public string FirstName;
        public string LastName;
        public Person Spouse;
        public static double AverageAge;


        public string GetFullName()
        {
            string FullName = " ";
            FullName += this.FirstName;
            FullName += " ";
            FullName += this.LastName;

            return FullName;




        }


        public void PrintNameAndAge()
        {


        }






    }
}
