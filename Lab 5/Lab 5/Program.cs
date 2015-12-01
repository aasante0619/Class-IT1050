using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Press Enter to Enter a Course!");


            Course CourseA = new Course();
            CourseA.GetCourseInfo();
            CourseA.PrintInfo();


            string AddMoreStudents;

            System.Console.WriteLine("Do you want to add more students? (y / n)");
            AddMoreStudents = System.Console.ReadLine();

            while (AddMoreStudents = y)
            {
                for (int StudentCount = 0; int <= 2; StudentCount++)
                {
                    System.Console.WriteLine(" What is the Student's Name?");
                    Student student = new Student();

                    System.Console.ReadLine() = student.StudentName;


                    System.Console.WriteLine(" What is the Student's S-Number? (no dashes)");
                    System.Console.ReadLine() = student.SNumber;



                }

            }

            System.Console.WriteLine("Press Enter to add students.");

            

            
        }
    }
}
