using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.ExceptionHandling
{
    internal class ExceptionHand
    {
        public static void Run()
        {
            try
            {
                Console.WriteLine("Enter a number : ");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter another number : ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Answer : " + num / num2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }


        }
    }
 }
