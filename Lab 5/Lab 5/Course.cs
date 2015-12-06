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
       
        

        public void GetClassInfo()
        {

            string Answer;

                       
            

        


            System.Console.WriteLine("How many students are in the Course?");
            int size = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Would you like to add students?");


            Answer = System.Console.ReadLine();
            while ((Answer.ToLower().StartsWith("y")))
           

            {

                for (int i = 0; i < size; i++)


                {
                    Students = new Student[size];
                    Students[i] = new Student();
 

                    System.Console.WriteLine("What is the Student's Name?");
                    this.Students[i].StudentName = System.Console.ReadLine();


                    System.Console.WriteLine("What is the S Number");
                    this.Students[i].SNumber = System.Console.ReadLine();

                    System.Console.WriteLine(" Student " + " is  " + this.Students[i].StudentName + " with Student Number " + this.Students[i].SNumber + " .");

                    System.Console.WriteLine("Would you like to add students?");


                    Answer = System.Console.ReadLine();
                }

            }
          
        }

        public void PrintCourseInfo()


        {
            string input;

            System.Console.WriteLine("What is the Course Name?");

            this.CourseName = System.Console.ReadLine();

            System.Console.WriteLine("What is the Course Number?");
            this.CourseNumber = System.Console.ReadLine();

            input = " The Course is  ";
            input += this.CourseName;
            input += " AKA ";
            input += this.CourseNumber;
            input += " .";

            System.Console.WriteLine(input);
        }


    }
}
