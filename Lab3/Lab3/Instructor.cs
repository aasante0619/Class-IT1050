using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Instructor
    {

        private string FirstName;
        private string LastName;
        private string CourseName;
        private string fullName;

        public Instructor (string instructoFirstName, string instructorLastName, string CourseNameGiven)
        {
            this.fullName = instructoFirstName + " " + instructorLastName;
            this.CourseName = CourseNameGiven;


        }

        public void SetStudentGrade(Student studentName, int GradeGiven)
        {

            GradeGiven = studentName.Grade;


       

        }

        public void PrintInfo(Instructor LastName, Instructor CourseName)
        {

            System.Console.WriteLine("Instructor " + this.fullName + " " + "teaches" + " " + this.CourseName);
            
        }














    }

    


   


}






