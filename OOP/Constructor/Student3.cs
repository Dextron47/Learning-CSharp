using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.OOP.Constructor
{
    internal class Student3
    {
        public string Name;
        public int rollNo;
        public string course;

        public Student3(string cName, int cRollNo, string cCourse)
        {
            Name = cName;
            rollNo = cRollNo;
            course = cCourse;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name : {Name} \nRoll No : {rollNo} \nCourse : {course}");
        }
        
    }
}
