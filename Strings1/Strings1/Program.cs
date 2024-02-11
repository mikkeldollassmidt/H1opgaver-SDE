namespace Strings1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating standard variable for userSeperatorInput
            string userSeperatorInput = null;

            // User interaction and saving values from user input into strings.
            Console.WriteLine("Please write a sentence:");
            string userWordInput = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please choose one character as seperator (standard '-'):");
            // Creating temporary seperator check to use in if statement.
            string tempSeperatorCheck = Console.ReadLine();

            // If to check if the user has used a one character seperator.
            if (tempSeperatorCheck.Length == 1)
            {
                // If tempseperatorcheck is one character long exceed to put values from tempseperatorcheck into userseperatorinput.
                userSeperatorInput = tempSeperatorCheck;
            } 
            else
            {
                // Standard seperator is used if user didn't type in a one character seperator. Standard seperator is "-"
                userSeperatorInput = "-";
            }
            Console.Clear();

            // Using method to add seperators.
            Console.WriteLine(AddSeparator(userWordInput,userSeperatorInput));
            Console.ReadLine();
        }
        public static string AddSeparator(string userWordInput, string userSeperatorInput)
        {
            // Standard variable for outputting string.
            string outputString = null;

            // Foreach to put in one character at a time and seperator behind it. Foreach is used to make a loop for every character in userWordInput.
            foreach(char c in userWordInput)
            {
                // Add character from userWordInput to outputString and add the seperator chosen by the user.
                outputString += c;
                outputString += userSeperatorInput;
            }

            // Return output.
            return outputString;
        }
    }
}