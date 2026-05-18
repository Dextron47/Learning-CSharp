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
    }
}
