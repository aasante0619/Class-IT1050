using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Redo
{
    class Program
    {
        static void Main(string[] args)
        {

            Person.Count = 0;
            Person.SumOfAges = 0;


            Person person1 = new Person();
            person1.GetFullName();
            person1.GetAge();
            person1.PrintNameAndAge();
            person1.CreateSpouseIfMarried();
     
     
            
           


            Person.Count ++;
            Person.SumOfAges += person1.Age;



            Person person2 = new Person();
            person2.GetFullName();
            person2.GetAge();
            person2.PrintNameAndAge();
            person2.CreateSpouseIfMarried();


            Person.Count++;
            Person.SumOfAges += person2.Age;

            Person person3 = new Person();
            person3.GetFullName();
            person3.GetAge();
            person3.PrintNameAndAge();
            person3.CreateSpouseIfMarried();


            Person.Count++;
            Person.SumOfAges += person3.Age;

            System.Console.WriteLine("Average Age: " + Person.AverageAge());
            System.Console.ReadKey();

        }
    }
}
