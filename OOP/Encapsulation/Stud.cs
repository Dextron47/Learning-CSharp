using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.OOP.Encapsulation
{
    internal class Stud
    {
        private int age;
        private string name;

        public void setAge(int value)
        {
            if (value > 0)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("Age is invalid");
            }
        }

        public int getAge()
        {
            return age;
        }
    }
}
