using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramGenerics
{
    class GenericRefactor2<T> where T : IComparable
    {
        public T first, second, third;

        public GenericRefactor2(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public static T FindMax(T first, T second, T third)
        {
            if (first.CompareTo(second) >= 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine(" Greater Value :" + first);
                return first;

            }
            else if (second.CompareTo(third) > 0)
            {
                Console.WriteLine("Greater Value :" + second);
                return second;
            }
            else
            {
                Console.WriteLine(" Greater Value :" + third);
                return third;
            }
        }

        public void TestMaximum()
        {
            T result = FindMax(first,second,third);
            Console.WriteLine("Max value is:" + result);
        }
    }
}
