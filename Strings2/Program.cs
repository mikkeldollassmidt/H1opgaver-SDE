namespace Strings2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User interaction, creating variables and putting value in them.
            Console.WriteLine("Write a word and check if it's a palindrome (in lower case.):");

            // Creating a temp string to make all userInput to lower.
            string userInputTemp = Console.ReadLine();
            string userInput = userInputTemp.ToLower();
            Console.Clear();

            // Using method to test if userInput is palindrome.
            Console.WriteLine(IsPalindrome(userInput));
            Console.ReadLine();
        }
        public static bool IsPalindrome(string userInput)
        {
            string userInputReversed = "";

            // For loop to reverse userInput. - 1, because of index is 0 / First letter will be on index 0.
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                // Write reversed into userInputReversed.
                userInputReversed += userInput[i];
            }

            // Check if user input reversed and user input is the same (isPalindrome) and return bool.
            if (userInputReversed == userInput)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}