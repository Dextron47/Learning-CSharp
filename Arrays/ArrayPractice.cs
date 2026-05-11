using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.Arrays
{
    public class ArrayPractice
    {
        public static void Run()
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            string[] friends = new string[5];

            friends[0] = "Kevin";
            friends[1] = "Karen";
            friends[2] = "Oscar";
            friends[3] = "Angela";
            friends[4] = "Andy";

            Console.WriteLine(friends[0]);

            luckyNumbers[1] = 900;

            Console.WriteLine(luckyNumbers[1]);
        }
 
    }
}
