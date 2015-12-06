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

            Course CourseA = new Course();
            CourseA.PrintCourseInfo();
   
            
            CourseA.GetClassInfo();
           

            System.Console.ReadKey();

        }
    }
}