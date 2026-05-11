using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.IfStatement
{
    internal class Calculator
    {
        public static void Run()
        {

            double num1, num2;
            string op;

            Console.WriteLine("Enter first number : ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter operation (+, -, *, /) : ");
            op = Console.ReadLine();

            Console.WriteLine("Enter second number : ");
            num2 = Convert.ToDouble(Console.ReadLine());
          

            double ans = 0;

            if(op == "+")
            {
                ans = num1 + num2;
            }else if(op == "-") {
                ans = num1 - num2;
            }else if(op == "*") {
                ans = num1 * num2;
            }else if(op == "/") {
                ans = num1 / num2;
            }else {
                Console.WriteLine("Invalid operation");
                ans = 0;
            }
            Console.WriteLine("Result: " + ans);

        }
    }
}


    