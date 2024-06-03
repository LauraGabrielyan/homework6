using System.Runtime.Intrinsics.X86;

namespace taskk16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 16: Determine the Smallest of Four Numbers
            //Create four variables x, y, z, and w and assign them values.
            //Use nested if statements to find and print the smallest value among the four numbers
            Console.WriteLine("Enter number1");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number3");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number4");
            int number4 = Convert.ToInt32(Console.ReadLine());
            
            int minnumber = number1;
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
            Console.WriteLine("The min number is " + minnumber);
        }
    }
}
