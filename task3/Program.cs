using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Buffers.Text;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 3: Nested if Statements
            //Create a variable number and assign it a value.
            //Use nested if statements to check the range of the number:
            //If number is greater than 0, check if it is less than 50.
            //Print appropriate messages for each range.
            int number;
            Console.WriteLine("Please enter number");
            number = Convert.ToInt32(Console.ReadLine());
            if(number>0)
            {
                if(number<50)
                {
                    Console.WriteLine("The number is greater than 0 and less than 50 ");
                }
                if(number>50)
                {
                    Console.WriteLine("The number is greater than 0 but not less than 50 ");
                }
                if (number == 50)
                {
                    Console.WriteLine("The number is greater than 0 and equal to 50 ");
                }
            }
           if (number<0) 
           {
                Console.WriteLine("The number is less than 0 ");
            }

        }
    }
}
