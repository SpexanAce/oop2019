using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Exercise
{
    class Exercise3
    {
        public static void PalindromeCheck(string line)
        {
            Console.WriteLine("Write a word that you think is a Palindrome");
            string x = Console.ReadLine();

        var original = x;
        var reversed = new string(original.Reverse().ToArray());
        var palindrom = original == reversed;
            if (palindrom == true)
            {
                Console.WriteLine("Yes "+original+" is a Palindrome");
            }
            else
            {
                Console.WriteLine("No " + original + " aint no Palindrome");
            }
        }
    }
}
