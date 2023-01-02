using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramGenerics
{
    internal class FindMaxintValue
    {
        //UC1
        public static int MaxValue(int a,int b,int c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
            {
                Console.WriteLine("Greater Value :" + a);
                return a;

            }
            else if (b.CompareTo(c) > 0)
            {
                Console.WriteLine("Greater Value :" + b);
                return b;
            }
            else
            {
                Console.WriteLine("Greater Value :" + c);
                return c;
            }

        }
    }
}
