using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.OOP.Polymorphism
{
    internal class Circle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Drawing a circle");
        }
    }
}
