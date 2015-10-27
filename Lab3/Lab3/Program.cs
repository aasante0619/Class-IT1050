

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {


           Instructor John = new Instructor("John", "Smith", "English");

            John.PrintInfo();
            
           Instructor Mike = new Instructor("Mike", "Jones", "Math");
            Mike.PrintInfo();

            Student Jane = new Student("Jane", "Adams", John, 0);
            Student Joe = new Student("Joe", "Jenkins", John, 0);
            Student Melissa = new Student("Melissa", "King", Mike, 0);
            Student Matt = new Student("Matt", "Sanchez", Mike, 0);

            John.SetStudentGrade(Jane, 95);
            John.SetStudentGrade(Joe, 85);
            Mike.SetStudentGrade(Melissa, 90);
            Mike.SetStudentGrade(Matt, 92);

            Jane.PrintNameTeacherCourse();

            Joe.PrintNameTeacherCourse();

            Melissa.PrintNameTeacherCourse();

            Matt.PrintNameTeacherCourse();


          
            System.Console.ReadKey();






        }
    }
}
