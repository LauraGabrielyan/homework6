using System.Runtime.Intrinsics.X86;

namespace taskk15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Task 15: Determine the Largest of Four Numbers
            //Create four variables a, b, c, and d and assign them values.
            //Use nested if statements to find and print the largest value among the four numbers.
            Console.WriteLine("Enter number1");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number3");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number4");
            int number4 = Convert.ToInt32(Console.ReadLine());
           ;
            int maxnumber = number1;
            if (maxnumber < number2)
            {
                maxnumber = number2;
            }
            if (maxnumber < number3)
            {
                maxnumber = number3;
            }
            if (maxnumber<number4)
            {
                maxnumber = number4;
            }
            Console.WriteLine("The max number is " + maxnumber);
        }
    }
}
