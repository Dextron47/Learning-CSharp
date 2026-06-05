using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.OOP.Interfaces
{
    internal class Duck : ISwim, IFly
    {
        public void Fly()
        {
            Console.WriteLine("Duck flies");
        }

        public void Swim()
        {
            Console.WriteLine("Duck swims");
        }
    }
}
