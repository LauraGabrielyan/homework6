using System;
using System.Runtime.Intrinsics.X86;
using System.Threading;

namespace taskk17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   Task 17: Determine the Type of Triangle
            //Create three variables a, b, and c representing the sides of a triangle.
            //Use nested if statements to determine if the triangle is equilateral, isosceles, or scalene.
            //Print the type of triangle.
            Console.WriteLine("Enter a");
            sbyte a = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Enter b");
            sbyte b = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Enter c");
            sbyte c = Convert.ToSByte(Console.ReadLine());
             if (a==b && a == c)
             {
                Console.WriteLine("The triangle is  isosceles");
             }
              else 
              if (a==b || a==c|| b == c)
              {
                Console.WriteLine("The triangle is  equilateral");
              }
             else
             {
                Console.WriteLine("The triangle is  scalene");
             }
   

        }
    }
}
