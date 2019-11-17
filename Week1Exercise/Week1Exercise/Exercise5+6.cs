using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Exercise
{
    class Exercise5
    {
        public static void GuessingGame()

        {

            Random random = new Random();

            int rightNumber = random.Next(1, 99);

            Console.WriteLine("I am thinking of a number between 1-99.  Which one?");

            int Guess = Exercise1.ReadInt("");

            int ComputerGuessMax = 99;
            int ComputerGuessMin = 1;
            int ComputerGuess = random.Next(ComputerGuessMin, ComputerGuessMax);


            while (Guess != rightNumber)
            {
               

                if (Guess < rightNumber)
                {
                    Console.WriteLine("No its higher than " + Guess + ".");
                    
                }
                if (Guess > rightNumber)
                {
                    Console.WriteLine("No, its lower than " + Guess + ".");
                    //Guess = Exercise1.ReadInt("");
                }
                if(ComputerGuess < rightNumber)
                {
                    Console.WriteLine("Computer think its "+ComputerGuess+" But its higher. ");
                    ComputerGuessMin = ComputerGuess;
                    ComputerGuess = random.Next(ComputerGuessMin, ComputerGuessMax);
                }
                if (ComputerGuess > rightNumber)
                {
                    Console.WriteLine("Computer think its " + ComputerGuess + " But its lower. ");
                    ComputerGuessMax = ComputerGuess;
                    ComputerGuess = random.Next(ComputerGuessMin, ComputerGuessMax);
                }
                if (ComputerGuess == rightNumber)
                {
                    Console.WriteLine("Well done Mr Roboto! You beat the human, the number is " + rightNumber);
                }
                Guess = Exercise1.ReadInt("");
            }

            Console.WriteLine("Well done! I was thinking of " + rightNumber);
            Console.ReadLine();

        }
    }
}
