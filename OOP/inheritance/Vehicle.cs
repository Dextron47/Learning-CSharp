using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.OOP.inheritance
{
    internal class Vehicle
    {
        public string Brand;

        public void Start()
        {
            Console.WriteLine($"{Brand} is starting");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} is stopping");
        }
    }

}
