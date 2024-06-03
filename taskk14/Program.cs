using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;

namespace taskk14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Task 14: Age Group Classification
            //Create a variable age and assign it a value.
            //Use an if-else if-else statement to classify the age into "Child", "Teenager", "Adult", and "Senior".
            //Print the appropriate age group based on the age.
            Console.WriteLine("Enter age");
            sbyte age=Convert.ToSByte(Console.ReadLine());
            if (age<=1)
            {
                Console.WriteLine("Infant ");
            }
            else if (age <= 4)
            {
                Console.WriteLine("Toddler");
            }
            else if (age <= 12)
            {
                Console.WriteLine("Child");
            }
            else if (age <= 19)
            {
                Console.WriteLine("Teenager");
            }
            else if (age <= 39)
            {
                Console.WriteLine("Adult");
            }
            else if (age <= 59)
            {
                Console.WriteLine("Middle Age Adult ");
            }
            else if (age >=60)
            {
                Console.WriteLine("Senior Adult");
            }



        }
    }
}
