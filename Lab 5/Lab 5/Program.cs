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
        }
    }
}