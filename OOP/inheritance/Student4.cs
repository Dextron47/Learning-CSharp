using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.OOP.inheritance
{
    internal class Student4 : Person2
    {
        public string Course;
        //public string Name;

        public void Study()
        {
            Console.WriteLine($"Student is studying {Course}");
        }
        
    }
}
