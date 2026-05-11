using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.IfStatement
{
    internal class If2
    {
        public static void Max()
        {
            int num1, num2;

            Console.WriteLine("Enter first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Max is : " + num1);
            }
            else
            {
                Console.WriteLine("Max is : " + num2);
            }
        }

        public static int Min(int num1, int num2, int num3)
        {
            int min;

            if(num1 < num2 && num1 < num3)
            {
                min = num1;
            }
            else if(num2 < num1 && num2 < num3)
            {
                min = num2;
            }
            else
            {
                min = num3;
            }

            return min;

        }
    }
}
