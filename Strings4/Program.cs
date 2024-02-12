namespace Strings4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User interaction, creating variables and putting value in them from user input.
            Console.WriteLine("Write a word or sentence:");
            string userInput = Console.ReadLine();
            Console.Clear();

            Console.WriteLine(StringInReverseOrder(userInput));
            Console.ReadLine();
        }
        public static string StringInReverseOrder(string userInput)
        {
            // Standard variable for reversed userinput.
            string userInputReversed = null;

            // For loop to reverse userInput. - 1, because of index is 0 / First letter will be on index 0.
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                // Write reversed into userInputReversed.
                userInputReversed += userInput[i];
            }

            // Return userInput in reversed order.
            return userInputReversed;
        }
    }
}
