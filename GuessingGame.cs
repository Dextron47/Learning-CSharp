using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2
{
    internal class GuessingGame
    {
        public static void Run()
        {
            string secretWord = "giraffe";
            string guess = "";

            while(guess != secretWord)
            {
                Console.WriteLine("Enter guess : ");
                guess = Console.ReadLine();
            }

            Console.WriteLine("You win!");
        }

        public static void Run2()
        {
            int secretNum = 4;
            int guessNum;

            do
            {
                Console.WriteLine("Enter guess : ");
                guessNum = Convert.ToInt32(Console.ReadLine());
            }while(guessNum != secretNum);

            Console.WriteLine("You win!");

        }

    }
}
