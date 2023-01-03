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
            Console.WriteLine("1:Find Max Int Value\n2:Find Max Float Value\n3:Find Max String\n4:Generic Refactor1\n5:Generic Refactor2\n");
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
                case 3:
                    FindMaxString.Maxstring("Jayesh", "Pallavi", "Priyansh");
                    break;
                case 4:
                    GenericRefactor1<int>.FindMax(100, 600, 400);
                    GenericRefactor1<float>.FindMax(12.3f, 20.5f, 40.2f);
                    GenericRefactor1<string>.FindMax("Pallavi","Jayesh","Priyansh");
                    break;
                case 5:
                    GenericRefactor2<float> genericRefactor2 = new GenericRefactor2<float>(23.2f, 40.2f, 12.3f);
                    genericRefactor2.TestMaximum();
                    GenericRefactor2<int> genericRefactor= new GenericRefactor2<int>(23, 40, 12);
                    genericRefactor.TestMaximum();
                    break;

            }

            Console.ReadLine();
        }
    }
}
