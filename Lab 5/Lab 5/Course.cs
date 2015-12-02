using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Course
    {
        public string CourseName;
        public string CourseNumber;

        public Student[] Students;




        public void GetCourseInfo()
        {

            System.Console.WriteLine("What is the Course Name?");

            this.CourseName = System.Console.ReadLine();

            System.Console.WriteLine("What is the Course Number?");
            this.CourseNumber = System.Console.ReadLine();

            System.Console.WriteLine("How many students are in the Course?");
            int size = int.Parse(System.Console.ReadLine());

            Students = new Student[size];

            for (int i = 0; i < size; i++)
            {
                Students[i] = new Student();

                System.Console.WriteLine( "What is the Student's Name?");

                this.Students[i].StudentName = System.Console.ReadLine();

                System.Console.WriteLine("What is the S Number");

                System.Console.ReadLine() = this.Student.SNumber;

            }

        }

        public void PrintInfo()
        {
            string input;
            input = " The Course is  ";
            input += this.CourseName;
            input += " AKA ";
            input += this.CourseNumber;
            input += " .";

            System.Console.WriteLine(input);
        }


    }
}
