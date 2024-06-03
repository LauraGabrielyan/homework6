using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;

namespace taskk12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 12: Determine if a Number is Positive, Negative, or Zero
            //Create a variable num and assign it a value.
            //Use an if-else if-else statement to determine if the number is positive, negative, or zero.
            //Print the result.
            Console.WriteLine("Enter number");
            int num=Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("The number is zero");
            } 
            else
            if(num >0) 
            {
                Console.WriteLine("The number is positive");
            }
            else 
            {
                Console.WriteLine("The number is negative");
            }
              

            
        }
    }
}
