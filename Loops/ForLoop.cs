using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.Loops
{
    internal class ForLoop
    {
        public static void Run()
        {
            for(int i = 1; i <= 5; i++)
            {
                Console.Write(i + " ");
            }
        }

        public static void Run2()
        {
            int[] arr = new int[5];

           
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the " + (i+1) + " number: " );
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The numbers you entered are : "); 
            for(int i = 0; i <= arr.Length-1; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
