using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arithmetic_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f;
            Console.WriteLine("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;
            Console.WriteLine("Addition of two number : " +c);

            d = a - b;
            Console.WriteLine("Substraction of two number : " +d);

            e = a * b;
            Console.WriteLine("Multiplication of two number : " +e);

            f = a / b;
            Console.WriteLine("Division of two number : " +f);


            
            Console.ReadLine();
        }
    }
}
