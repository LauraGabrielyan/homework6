using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;

namespace taskk18
{
    internal class Program
    {
        static void Main(string[] args)
        {

         //  Task 18: Menu Selection Using Switch
         //Create a variable option and assign it a value between 1 and 5.
         //Use a switch statement to print the selected option:
         //   1: "Option 1 selected"
         //2: "Option 2 selected"
         //3: "Option 3 selected"
         //4: "Option 4 selected"
         //5: "Option 5 selected"
         //For any other value, print "Invalid option".

            Console.WriteLine("Enter value between 1 and 5 ");
            byte option = Convert.ToByte(Console.ReadLine());
            

            
            switch (option)
            {
                case 1:
                    Console.WriteLine("Option 1 selected");
                    break;
                case 2:
                    Console.WriteLine("Option 2 selected");
                    break;
                case 3:
                    Console.WriteLine("Option 3 selected");
                    break;
                case 4:
                    Console.WriteLine("Option 4 selected");
                    break;
                case 5:
                    Console.WriteLine("Option 5 selected");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}
