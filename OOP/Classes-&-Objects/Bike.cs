using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.OOP.Classes___Objects
{
    internal class Bike
    {
        public string Brand;
        public string Color;
        public string Model;

        public void Start()
        {
            Console.WriteLine($"{Brand} has started");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} has stopped");
        }
    }
}
