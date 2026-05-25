using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.OOP.Classes___Objects
{
    internal class Student2
    {
        public string name;
        public int age; 
        public int rollNo;
        public string course;

        //public Student2(string aName,int anAge, int aRollNo, string aCourse)
        //{
        //    name = aName;
        //    age = anAge;
        //    rollNo = aRollNo;
        //    course = aCourse;
        //}

        public void StudentDetails()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Roll No: " + rollNo);    
            Console.WriteLine("Course : " + course);
        }
    }


}
