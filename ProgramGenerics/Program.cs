using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
            Console.WriteLine("1:Find Max Int Value\n2:Find Max Float Value\n");
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
                case 2:
                    //Console.WriteLine("Enter The First Number");
                    //float x = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("Enter The Second Number");
                    //float y = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("Enter The Third Number");
                    //float z = Convert.ToInt32(Console.ReadLine());
                    FindMaxFloatValue.MaxValue(12.3f,25.3f,4.6f);
                    break;
            }

            Console.ReadLine();
        }
    }
}
