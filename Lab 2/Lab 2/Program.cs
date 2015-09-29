using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person person1 = new Person();
            System.Console.WriteLine("What is the first name of Person 1?");
            person1.FirstName = System.Console.ReadLine();

            System.Console.WriteLine("What is the last name of Person 1?");
            person1.LastName = System.Console.ReadLine();

            System.Console.WriteLine("Whatis the age of Person 1?");
            person1.age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Is this person married? Answer true or false.");
            person1.isMarried = bool.Parse(System.Console.ReadLine());

            if (System.Console.ReadLine().ToLower().StartsWith("t"))
            {
                person1.Spouse = new Person();
                System.Console.WriteLine("What is thes spouse's Name?");
                person1.Spouse.FirstName = System.Console.ReadLine();
                System.Console.WriteLine("How old is the spouse? ");
                person1.Spouse.age = int.Parse(System.Console.ReadLine());
                
         

            }

            person1.GetFullName();
            person1.PrintNameAndAge();
            person1.Spouse.GetFullName();
            person1.Spouse.PrintNameAndAge();



            Person person2 = new Person();
            System.Console.WriteLine("What is the first name of Person 2?");
            person2.FirstName = System.Console.ReadLine();

            System.Console.WriteLine("What is the last name of Person 2?");
            person2.LastName = System.Console.ReadLine();

            System.Console.WriteLine("Whatis the age of Person 2?");
            person2.age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Is this person married? Answer true or false.");
            person2.isMarried = bool.Parse(System.Console.ReadLine());

            if (System.Console.ReadLine().ToLower().StartsWith("t"))
            {
                person2.Spouse = new Person();
                System.Console.WriteLine("What is thes spouse's Name?");
                person2.Spouse.FirstName = System.Console.ReadLine();
                System.Console.WriteLine("How old is the spouse? ");
                person2.Spouse.age = int.Parse(System.Console.ReadLine());



            }
            person2.GetFullName();
            person2.PrintNameAndAge();
           
            person2.Spouse.GetFullName();
            person2.Spouse.PrintNameAndAge();


            Person person3 = new Person();
            System.Console.WriteLine("What is the first name of Person 3?");
            person3.FirstName = System.Console.ReadLine();

            System.Console.WriteLine("What is the last name of Person 3?");
            person3.LastName = System.Console.ReadLine();

            System.Console.WriteLine("Whatis the age of Person 3?");
            person3.age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Is this person married? Answer true or false.");
            person3.isMarried = bool.Parse(System.Console.ReadLine());


            if (System.Console.ReadLine().ToLower().StartsWith("t"))
            {
                person3.Spouse = new Person();
                System.Console.WriteLine("What is thes spouse's Name?");
                person3.Spouse.FirstName = System.Console.ReadLine();
                System.Console.WriteLine("How old is the spouse? ");
                person3.Spouse.age = int.Parse(System.Console.ReadLine());



            }
            person3.GetFullName();
            person3.PrintNameAndAge();

            person3.Spouse.GetFullName();
            person3.Spouse.PrintNameAndAge();















        }
    }
}
