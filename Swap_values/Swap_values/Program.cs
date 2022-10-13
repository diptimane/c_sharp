using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Swap_values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swaping value");

            Console.WriteLine("value of a : " +a);

            Console.WriteLine("value of b : " +b);

            c = a;
            a = b;
            b = c;

            Console.WriteLine("after swapping value : ");

            Console.WriteLine("value of a : " +a);

            Console.WriteLine("value of b : " +b);

            Console.ReadLine();
        }
    }
}
