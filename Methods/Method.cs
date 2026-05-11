using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.Methods
{
    internal class Method
    {
        public static void SayHi()
        {
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
        }

        public static void SayHello(string name, int age)
        {
            Console.WriteLine("Hello, " + name + "! You are " + age + " years old.");
        }


    }
}
