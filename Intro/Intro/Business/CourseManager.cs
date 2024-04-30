using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business
{
    public class CourseManager
    {

        Course[] courses = new Course[3];
        public CourseManager()
        {
            Console.WriteLine("Başladı"); // class newlendıgı anda constructor calısır

            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "C#";
            course1.Description = ".Net8";
            course1.Price = 0;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "java";
            course2.Description = "Java17";
            course2.Price = 0;

            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "python";
            course3.Description = "Python3.12";
            course3.Price = 0;


            courses[0] = course1;
            courses[1] = course2;
            courses[2] = course3;
            
        }
        public Course[] GetAll()
        {
            return courses;
        }
    }
}
