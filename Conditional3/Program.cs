namespace Conditional3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // While to make the user able to startover if exception.
            while (true)
            {
                // Start by clearing everything. And capturing into ch what user inputs is.
                Console.Clear();
                Console.WriteLine("Write a 3 characters long word:");
                string ch = Console.ReadLine();

                // Check if user input is smaller or bigger than 3.
                if (ch.Length != 3)
                {
                    // Show error when user input isn't 3 characters long.
                    Console.Clear();
                    Console.WriteLine("Word should be 3 characters long.");

                    // Change foreground color to darkgray, write a user interface message for the user to startover. And reset color.
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Press ENTER to start over...");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                }
                else
                {
                    // Write result with user input if no errors.
                    Console.Clear();
                    Console.WriteLine(IfConsistsOfUppercaseLetters(ch));
                    Console.ReadLine();
                }
            }
        }
        public static bool IfConsistsOfUppercaseLetters(string ch)
        {
            // Bool is standard true.
            bool isCharactersUppercase = true;

            // Foreach to check every character in users input.
            foreach (char c in ch)
            {
                // Checks if the current character is uppercase.
                if (!Char.IsUpper(c))
                {
                    // If one character isn't uppercase, then make bool false.
                    isCharactersUppercase = false;
                }
            }
            // Return bool results.
            return isCharactersUppercase;
        }
    }
}
