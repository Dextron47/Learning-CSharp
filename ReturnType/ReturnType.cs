using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.ReturnType
{
    internal class ReturnType
    {
        public static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}
