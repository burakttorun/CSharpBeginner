using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Course[] courses = new Course[2];

            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.InstructorName = "BurakT";
            course1.ViewRate = 50;

            Course course2 = new Course { CourseName = "Java", InstructorName = "BurakT", ViewRate = 100 };

            courses[0] = course1;
            courses[1] = course2;
            

            foreach (var course in courses)
            {
                Console.WriteLine("Course name: {0} -Instructor name: {1} --> View rate: {2}"
                    ,course.CourseName,course.InstructorName,course.ViewRate);
            }

            Console.ReadLine();
        }
    }
}
