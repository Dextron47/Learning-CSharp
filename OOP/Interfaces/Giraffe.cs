using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.OOP.Interfaces
{
    internal class Giraffe : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Giraffe makes a sound");
        }
    }
}
