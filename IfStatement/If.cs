using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.IfStatement
{
    internal class If
    {
        public static void Run()
        {
            Console.WriteLine("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a minor.");
            }
        }

        public static void Run2()
        {
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();

            if (name.Equals("Sudhanshu"))
            {
                Console.WriteLine("Welcome, Admin!");
            }
            else
            {
                Console.WriteLine("Welcome, " + name + "!");
            }

        }

        public static void Run3()
        {
            bool isMale = false;
            bool isTall = false;

            if(!isMale && !isTall) {

                Console.WriteLine("You are not male and not tall.");
            } else if(!isMale)
            {
                Console.WriteLine("You are not male.");
            }
            else if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male.");
            }
            else if(isMale && !isTall)
            {
                Console.WriteLine("You are a short male.");
            }
            else if(!isMale && isTall)
            {
                Console.WriteLine("You are not male but you are tall.");
            }   
            else
            {
                Console.WriteLine("You are either not male or not tall or not both");
            }
        }
    }
}
