using System.Runtime.Intrinsics.X86;

namespace taskk11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 11: Combining if-else and switch
            //Create a variable menuOption and assign it a value between 1 and 3.
            //Use an if-else statement to check if the menuOption is valid(between 1 and 3).
            //If valid, use a switch statement to print the corresponding menu option:
            //1: "Start Game"
            //2: "Load Game"
            //3: "Exit"
            Console.WriteLine("Enter value between 1 and 3 ");
            byte menuOption=Convert.ToByte(Console.ReadLine());

            
            if (menuOption >=1 && menuOption <= 3) 
            {
                switch (menuOption)
                {
                    case 1:
                        Console.WriteLine("Start Game");
                        break;
                    case 2:
                        Console.WriteLine("Load Game");
                        break;
                    case 3:
                        Console.WriteLine("Exit");
                        break;

                }
               
            }
            else 
                Console.WriteLine("Invalid");
        }
    }
}
