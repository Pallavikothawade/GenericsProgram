using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramGenerics
{
    class FindMaxString
    {
        public static string Maxstring(string first, string second, string third)
        {
            if (first.CompareTo(second) >= 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine("First string Greater Value :" + first);
                return first;

            }
            else if (second.CompareTo(third) > 0)
            {
                Console.WriteLine("second string Greater Value :" + second);
                return second;
            }
            else
            {
                Console.WriteLine("Third string Greater Value :" + third);
                return third;
            }

        }
    }
}
