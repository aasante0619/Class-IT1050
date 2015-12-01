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
        

        public void GetCourseInfo()

        {
            

            System.Console.WriteLine("What is the Course Name?");

            this.CourseName = System.Console.ReadLine();

            System.Console.WriteLine("What is the Course Number?");
            this.CourseNumber = System.Console.ReadLine();

            System.Console.WriteLine("How many students are in the Course?");
            this.StudentList = System.Console.ReadLine();

        }

        public void PrintInfo()

        {
            string input;
            input = " The Course is  ";
            input +=  this.CourseName;
            input += " also called";
            input += this.CourseNumber;
            input += " ."


            System.Console.WriteLine(input);
        }


    }
}
