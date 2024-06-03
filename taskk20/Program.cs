using System.Runtime.Intrinsics.X86;

namespace taskk20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 20: Determine the Largest and Smallest of Five Numbers
            // Create five variables a, b, c, d, and e and assign them values.
            //Use nested if statements to find and print the largest and smallest values among the five numbers.
            Console.WriteLine("Enter number1");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number3");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number4");
            int number4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number5");
            int number5 = Convert.ToInt32(Console.ReadLine());
            
            int maxnumber = number1;
            int minnumber = number2;
            if (maxnumber < number2)
            {
                maxnumber = number2;
            }
            if (maxnumber < number3)
            {
                maxnumber = number3;
            }
            if (maxnumber < number4)
            {
                maxnumber = number4;
            }
            if (maxnumber < number5)
            {
                maxnumber = number5;
            }

            Console.WriteLine("The max number is " + maxnumber);
            if (minnumber > number2)
            {
                minnumber = number2;
            }
            if (minnumber > number3)
            {
                minnumber = number3;
            }
            if (minnumber > number4)
            {
                minnumber = number4;
            }
            if (minnumber > number5)
            {
                minnumber = number5;
            }
            Console.WriteLine("The min number is " + minnumber);
        }
    }
}
