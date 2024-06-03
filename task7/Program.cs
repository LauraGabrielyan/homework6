using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Task 7: Complex Nested if Statements
            //   Create variables age and hasLicense.
            //   Use nested if statements to check if:
            //   age is greater than or equal to 18.
            //  hasLicense is true.
            //  Print "Can drive" if both conditions are met; otherwise, print appropriate messages.
            //
            Console.WriteLine("Please enter age");
            byte age=Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter 'true' if has licence and 'false' otherwise");
            bool hasLicense = Convert.ToBoolean(Console.ReadLine());
            if (hasLicense)
            {
                if(age>=18)
                {
                    Console.WriteLine("Can drive");
                }
                if (age <= 18)
                {
                    Console.WriteLine("Has licence but age is less than 18");
                }
            }
            if (hasLicense==false)
            {
                if (age >= 18)
                {
                    Console.WriteLine("Dose not have licence but age is greater than 18");
                }
                if (age <= 18)
                {
                    Console.WriteLine("Dose not have licence and age is less than 18");
                }
            }

        }
    }
}
