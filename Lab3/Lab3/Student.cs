

namespace Lab3
{
    class Student
    {
        private string FirstName;
        private string LastName;
        public int Grade;
        private Instructor Teacher;
        private string fullname;


        public Student(string studentFirstName, string studentLastName, Instructor Teacher, int Grade)
        {
            this.FirstName = studentFirstName;
            this.LastName = studentLastName;
            this.fullname = this.FirstName + " " + this.LastName;
            this.Teacher = Teacher;
            this.Grade = Grade;
        }

        public void SetPupilGrade(int Grade)
        {
            this.Grade = Grade;
        }

        public void PrintNameTeacherCourse()
        {
            System.Console.WriteLine(this.fullname + " " + " got a" + " " + this.Grade + " " + " in "  +  this.Teacher + "'s" + "Class.");

        }
    }
}

    


