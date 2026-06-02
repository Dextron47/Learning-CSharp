using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.OOP.inheritance
{
    internal class Person2
    {
        //private string Name;
        //private int Age;

        public string Name {  get; set; }
        public int age;

        public int Age
        {
           get { return age; }
           set
            {
                if(value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age is invalid");
                }
            }
        }

        //public string name
        //{
        //    get { return Name; }
        //    set { Name = value; }
        //}
        //public int age
        //{
        //    get { return Age; }
        //    set { Age = value; }        
        //}
        public void DisplayInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age : {age}");
        }
    }
}
