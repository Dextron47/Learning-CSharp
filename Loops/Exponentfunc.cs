using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.Exponent_Function
{
    internal class Exponentfunc
    {
        public static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for(int i = 0; i < powNum; i++)
            {
                result *= baseNum;
            }

            return result;
        }

    }
}
