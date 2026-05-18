using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.Arrays
{
    internal class TwoDim
    {
        public static void Run()
        {
            int[,] numberGrid =
            {
                {1,2, 3},
                {4, 5, 6},
                {7, 8, 9}

            };

            int[,] myArray = new int[2,3];

            Console.WriteLine(numberGrid[1,1]);
        }
    }
}
