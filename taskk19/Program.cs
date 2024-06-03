using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

namespace taskk19
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //   Task 19: Check If a Character is a Vowel or Consonant
            //  Create a variable char and assign it a character.
            // Use a switch statement to check if the character is a vowel (a, e, i, o, u) or a consonant.
            //Print the result.
            Console.WriteLine("Enter character");
            char character = Convert.ToChar(Console.ReadLine());

            switch (character)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("The character is a vowel.");
                    break;
                default:
                    Console.WriteLine("The character is a consonant.");
                    break;
            }
        }
    }
}
