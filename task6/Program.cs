using System.Buffers.Text;
using System.Runtime.Intrinsics.X86;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 6: switch Statement with Strings
            //Create a variable command and assign it a value("start", "stop", "pause", "resume").
            //Use a switch statement to print appropriate messages based on the value of command.
            Console.WriteLine("Enter 'start' or 'stop' or 'pause' or 'resume'");
            string text = Console.ReadLine();
            switch(text)
            {
                case "start":
                    Console.WriteLine("START");
                    break;
                case "stop":
                    Console.WriteLine("STOP");
                    break;
                case "pause":
                    Console.WriteLine("PAUSE");
                    break;
                case "resume":
                    Console.WriteLine("RESUME");
                    break;
            }
        }
    }
}
