using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Redo
{
    class Person
    {

        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;

        public static double AverageAge()
        {
            return (double)Person.SumOfAges / (double)Person.Count;

        }


        public static int SumOfAges;

        public static int Count;

        public string GetFullName()
        {
            System.Console.WriteLine("What is the person's first name?");
            this.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("What is the person's last name?");
            this.LastName = System.Console.ReadLine();

            return (this.FirstName + this.LastName);

            
        }


        public void  GetAge()
        {

            System.Console.WriteLine("How old is the person?");
            this.Age = int.Parse(System.Console.ReadLine());


        }
  

        public void PrintNameAndAge()
        {

            System.Console.WriteLine(this.FirstName + " " + this.LastName + " " + "is" + " " + this.Age + " " + "years old");

        }


        public void CreateSpouseIfMarried()
        {
            System.Console.WriteLine("Are you married? Answer True or False");
            if (System.Console.ReadLine().ToLower().StartsWith("t"))


            {
                this.Spouse = new Person ();
                this.Spouse.GetFullName();
                this.Spouse.GetAge();
                this.Spouse.PrintNameAndAge();
                this.Spouse.Spouse = this;






            }


        }

    }
}
