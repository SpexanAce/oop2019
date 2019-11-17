using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Exercise
{
    class Exercise2
    {
        public static void LeapYear(string line)
        {
            // Checing the leap year between 2000 to 2019
            Console.WriteLine("Write a Year above 0 ");
            int x = Exercise1.ReadInt(line);
            Console.WriteLine("Write another Year above "+x);
            int z = Exercise1.ReadInt(line);

            for (int y = x; y <= z; y++)  
            { 
                if (DateTime.IsLeapYear(y))  
                { 
                Console.WriteLine("{0} *", y); 
                } 
                else 
                { 
                Console.WriteLine("{0}", y); 
                }
                
            }
            Console.WriteLine("LeapYears!!!!");
       }  
    }
}
