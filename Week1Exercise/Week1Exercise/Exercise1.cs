using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Exercise
{
    class Exercise1
    {
        public static int ReadInt(string line)
        {
            int X;

            String Result = Console.ReadLine();

            while (!Int32.TryParse(Result, out X))
            {
                Console.WriteLine("Thats not a number.....");

                Result = Console.ReadLine();
            }
            return X;
        }
    }
}
