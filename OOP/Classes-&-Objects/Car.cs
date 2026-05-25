using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.OOP.Classes___Objects
{
    internal class Car
    {
        public string Brand;
        public string Color;

        public void Start()
        {
            Console.WriteLine(Brand + " Car has started");
        }
        public void Stop()
        {
            Console.WriteLine($"{Brand} Car has stopped");
        }

    }
}
