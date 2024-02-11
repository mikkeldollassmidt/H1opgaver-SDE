namespace Strings3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User interaction and creating a string for capturing userInput
            Console.WriteLine("Write a word to check for length:");
            string userInput = Console.ReadLine();
            Console.Clear();

            // Use method to count length of a string
            Console.WriteLine(LengthOfAString(userInput));
            Console.ReadLine();
        }

        public static int LengthOfAString(string userInput)
        {
            // Standard variable for counting characters in userInput
            int characterCounter = 0;

            // Foreach character count characterCount up 1.
            foreach (char c in userInput)
            {
                characterCounter++;
            }

            return characterCounter;
        }
    }
}