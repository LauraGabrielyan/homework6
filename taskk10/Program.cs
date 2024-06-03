using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;

namespace taskk10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 10: Nested if with Multiple Conditions
            //Create variables a, b, and c.
            //Use nested if statements to find and print the largest number among a, b, and c
            Console.WriteLine("Enter number1");
            int number1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number3");
            int number3 = Convert.ToInt32(Console.ReadLine());
            int max = number1;
            if (max < number2)
            {
                max = number2;
            }
            if ( max<number3)
            {
                max = number3;
            }
            Console.WriteLine("The max number is " + max);
        }
    }
}
