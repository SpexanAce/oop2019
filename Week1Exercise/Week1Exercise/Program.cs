using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            int x = Exercise1.ReadInt("");
            Console.WriteLine("First Number is "+ x);
            Console.WriteLine("Type another number: ");
            int y = Exercise1.ReadInt("Type another number: ");
            Console.WriteLine("Second Number is " + y);
            Console.WriteLine($"{x} + {y} = {x + y}");
            Exercise2.LeapYear("");
            Exercise3.PalindromeCheck("");
            Console.WriteLine("Press Key to initiate FizzBuzz");
            Console.ReadLine();
            Exercise4.FizzBuzz();
            Console.WriteLine("Press Key to initiate Guessing Game");
            Console.ReadLine();
            Exercise5.GuessingGame();
            Console.ReadLine();
        }
    }

}
