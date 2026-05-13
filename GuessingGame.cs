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
            int guessCount = 0;
            int guesslimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if(guessCount < guesslimit)
                {
                    Console.WriteLine("Enter guess : ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
                
            }
            Console.WriteLine("Guess Count : " + guessCount);

            if(outOfGuesses == false)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }

          
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
