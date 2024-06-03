using System.Runtime.Intrinsics.X86;

namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 8: if with Logical Operators
            //Create variables temperature and isRaining.
            //Use an if statement with logical operators to check if:
            //temperature is greater than 20 and isRaining is false.
            //Print "Good weather for a walk" if the condition is met; otherwise, print "Stay indoors".
            Console.WriteLine("Enter temperature");
            sbyte temperature=Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Enter 'true' if it will rain and 'false' otherwise");
            bool isRaining= Convert.ToBoolean(Console.ReadLine());
            if (isRaining==false && temperature>=20) 
            {
                Console.WriteLine("Good weather for a walk");
            }
            else
            {
                Console.WriteLine("Stay indoors");
            }

        }
    }
}
