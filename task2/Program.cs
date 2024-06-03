using System.Buffers.Text;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Task 2: if-else Statement
           // Create a variable number and assign it a value.
           //Use an if-else statement to check if number is even or odd.
           //Print "The number is even" or "The number is odd" based on the condition.
            int number;
            Console.WriteLine("Please enter number");
            number = Convert.ToInt32(Console.ReadLine());
            if (number%2==0) 
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
