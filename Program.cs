using Giraffe2.Arrays;
using Giraffe2.Methods;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string characterName = "Tom";
            //int characterAge;
            //characterAge = 35;


            //Console.WriteLine("There was once an old man named " + characterName);
            //Console.WriteLine("He was of " + characterAge + " years old and lived in a small village.");

            //characterName = "Mike";
            //Console.WriteLine("He really liked his name " + characterName);
            //Console.WriteLine("But did not like his age " + characterAge);

            //string phrase = "Hello, World!" + " is cool";
            //char c = 'A';
            //int age = 30;

            //double pi = 3.14159;
            //bool isRaining = false;

            //Console.WriteLine("Giraffe \nAcademy");
            //Console.WriteLine("Giraffe\"Academy");
            //Console.WriteLine(phrase.Length);
            //Console.WriteLine(phrase.ToUpper());
            //Console.WriteLine(phrase.ToLower());

            //Console.WriteLine(phrase.Contains("World"));
            //Console.WriteLine(phrase[0]);
            //Console.WriteLine(phrase.IndexOf('z'));

            //Console.WriteLine(phrase.Substring(7));

            //Console.WriteLine(phrase);

            //Console.WriteLine(30);
            //Console.WriteLine(5 + 8);
            //Console.WriteLine(8-5);
            //Console.WriteLine(5 * 8);
            //Console.WriteLine(10 / 2);
            //Console.WriteLine(5 % 2);

            //int num = 6;
            //Console.WriteLine(num);

            //Console.WriteLine(num++);
            //Console.WriteLine(num--);

            //Console.WriteLine(Math.Abs(-5));
            //Console.WriteLine(Math.Pow(3, 2));
            //Console.WriteLine(Math.Min(2, 4));
            //Console.WriteLine(Math.Max(2, 4));
            //Console.WriteLine(Math.Tan(2));
            //Console.WriteLine(Math.Ceiling(2.2));
            //Console.WriteLine(Math.Sqrt(3));

            //Console.WriteLine(Math.Round(2.6));
            //Console.WriteLine(Math.Truncate(2.6));


            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Hello " + name + ", you are " + age + " years old.");

            //Console.Write("Enter 1st number: ");
            //double num1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter 2nd number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Select an operation: +, -, *, /");
            //string operation = Console.ReadLine();

            //if(operation == "+")
            //{
            //    Console.WriteLine("Result: " + (num1 + num2));
            //}
            //else if (operation == "-")
            //{
            //    Console.WriteLine("Result: " + (num1 - num2));
            //}
            //else if (operation == "*")
            //{
            //    Console.WriteLine("Result: " + (num1 * num2));
            //}
            //else if (operation == "/")
            //{
            //    Console.WriteLine("Result: " + (num1 / num2));
            //}
            //else
            //{
            //    Console.WriteLine("Invalid operation");
            //}

            //int num = Convert.ToInt32("12");

            //Console.WriteLine(num + 4);

            //MadLib.Run();
            //ArrayPractice.Run();
            Method.SayHi();
            Method.SayHello("Tom", 22);
            Method.SayHello("John", 24);
            Method.SayHello("Mike", 32);


        }
    }
}
