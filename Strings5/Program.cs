namespace Strings5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User interaction, creating variable and putting userinput value in it.
            Console.WriteLine("Please write a sentence (Example: Hello my name is..):");
            string userInput = Console.ReadLine();
            Console.Clear();

            // Using method to find number of words with the userinput
            Console.WriteLine(NumberOfWords(userInput));
            Console.ReadLine();
        }
        public static int NumberOfWords(string userInput)
        {
            // Split in a string array when user has used the space character. Every word before and after space gets put in a string array called userInputSplitSpaces.
            string[] userInputSplitSpaces = userInput.Split(' ');

            // Count how many values in array.
            int splitCount = userInputSplitSpaces.Count();

            // Return value.
            return splitCount;
        }
    }
}
