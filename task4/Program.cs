using System.Buffers.Text;
using System.Runtime.Intrinsics.X86;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 4: if-else if-else Ladder
            //Create a variable score and assign it a value.
            //Use an if-else if-else ladder to print grades based on the score:
            //>= 90: "A"
            //>= 80: "B"
            //>= 70: "C"
            //>= 60: "D"
            //< 60: "F"
            int number;
            Console.WriteLine("Please enter number");
            number = Convert.ToInt32(Console.ReadLine());
            if (number >= 90)
            {
                Console.WriteLine("A");
            }
            else if(number >=80)
            {
                Console.WriteLine("B");
            }
            else if (number >=70)
            {
                Console.WriteLine("C");
            }
            else if (number >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }

        }
    }
}
