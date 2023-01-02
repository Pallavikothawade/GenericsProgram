using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Generics Program");
            Console.WriteLine("Choose The Option From Below");
            Console.WriteLine("1:FindMaxValue\n2:");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                     Console.WriteLine("Enter The First Number");
                     int a = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Enter The Second Number");
                     int b = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Enter The Third Number");
                     int c = Convert.ToInt32(Console.ReadLine());
                     FindMaxintValue.MaxValue(a, b, c);
                     break;
            }

            Console.ReadLine();
        }
    }
}
