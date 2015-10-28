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

        public string GetFirstname()
        {
            return this.FirstName;
        }

        public Instructor(string firstName, string lastName, string courseName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.fullName = firstName + " " + lastName;
            this.CourseName = courseName;
        }

        public void SetStudentGrade(Student student, int GradeGiven)
        {
            student.SetPupilGrade(GradeGiven);
        }

        public void PrintInfo()
        {
            System.Console.WriteLine("Instructor " + this.fullName + " " + "teaches" + " " + this.CourseName);
        }












    }







}






