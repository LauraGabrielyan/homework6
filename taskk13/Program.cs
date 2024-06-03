using System.Buffers.Text;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace taskk13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 13: Grade Categorization
            //Create a variable grade and assign it a value.
            //Use an if-else if-else statement to categorize the grade into "Excellent", "Good", "Average", "Poor", and "Fail".
            //Print the appropriate category based on the grade
            Console.WriteLine("Enter grade");
            byte grade=Convert.ToByte(Console.ReadLine());
            if(grade > 0)
            {
                if (grade < 60)
                {
                    Console.WriteLine("Fail");
                } else if (grade <66)
                {
                    Console.WriteLine("Poor");
                } else if (grade < 73)
                {
                    Console.WriteLine("Average");

                }
                else if (grade < 86)
                {
                    Console.WriteLine("Good");
                }
                else if (grade < 89)
                {
                    Console.WriteLine("Very good");

                } else if(grade < 100)
                {
                    Console.WriteLine("Excellent");
                }


            } 
        }
    }
}
