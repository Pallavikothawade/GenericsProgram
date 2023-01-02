using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramGenerics
{
    class FindMaxFloatValue
    {
        public static float MaxValue(float x, float y, float z)
        {
            if (x.CompareTo(y) >= 0 && x.CompareTo(z) >= 0)
            {
                Console.WriteLine("Greater Value :" + x);
                return x;

            }
            else if (y.CompareTo(z) > 0)
            {
                Console.WriteLine("Greater Value :" + y);
                return y;
            }
            else
            {
                Console.WriteLine("Greater Value :" + z);
                return z;
            }

        }
    }
}
