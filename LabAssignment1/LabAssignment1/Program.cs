using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;

            System.Console.Write("What is your first name?");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your middle initial?");
            middleInitial = System.Console.ReadLine();

            System.Console.Write("What is your last name?");
            lastName = System.Console.ReadLine();

            fullName = "[" + firstName + " " + middleInitial + " " + lastName + "]";
            System.Console.WriteLine(fullName);

            System.Console.WriteLine(" What is your height in feet?");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many inches beyond your base height in feet should be added?");
            heightInches = int.Parse(System.Console.ReadLine());

            totalHeightCM = heightFeet + (2.54 * heightInches);
            System.Console.WriteLine("Total height for" + " " + fullName + " " + "is" + " " + totalHeightCM );

            System.Console.WriteLine("What is your age?");
            age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Are you a US Citizen?");
            isCitizen = bool.Parse(System.Console.ReadLine());

            


            System.Console.WriteLine(fullName + canVote);

            System.Console.ReadKey();




            

















        }
    }
}
