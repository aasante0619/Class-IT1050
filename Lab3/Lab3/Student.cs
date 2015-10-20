

namespace Lab3
{
    class Student
    {
        private string FirstName;
        private string LastName;
        public string Grade;
        private Instructor Teacher; 
        

        public Student (string studentFirstName, string studentLastName, Instructor LastName)

        {
            this.FirstName = studentFirstName;
            this.LastName = studentLastName;
            this.Teacher = LastName;
            
        }
        








    }
}
