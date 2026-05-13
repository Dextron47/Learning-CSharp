using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.Loops
{
    internal class WhileLoop
    {
        public static void Run()
        {
            int index = 1;
            while(index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
        }

        public static void Run2()
        {
            int index = 6;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);
        }
    }
}
