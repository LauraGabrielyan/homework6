using System.Runtime.Intrinsics.X86;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // Task 1: Basic if Statement
         //Create a variable number and assign it a value.
         //Use an if statement to check if number is greater than 10.
         //If it is, print "The number is greater than 10."

            int number;
            Console.WriteLine("Please enter number");
            number= Convert.ToInt32(Console.ReadLine());
           
            if (number>10)
            { 
                Console.WriteLine("The number is greater than 10.");
             } 
             if (number < 10)
            {
                Console.WriteLine("The number is not greater than 10");
            }

        }
    }
}
