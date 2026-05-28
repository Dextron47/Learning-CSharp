using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.OOP.Constructor
{
    internal class Bike2
    {
        public string Brand;
        public string Model;
        public string Color;

        public Bike2()
        {
            Brand = "Default Brand";
            Model = "Default Model";
            Color = "Default Color";
        }

        public Bike2(string cBrand, string cModel, string cColor)
        {
            Brand = cBrand;
            Model = cModel;
            Color = cColor;
        }

        public void Start()
        {
            Console.WriteLine($"{Brand} bike has started");
        }
    }
}
