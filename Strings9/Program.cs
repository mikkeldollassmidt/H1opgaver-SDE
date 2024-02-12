namespace Strings9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = null;

            // user interaction, temporary userInput for checking if empty.
            Console.WriteLine("Write a sentence (can't be null, otherwise it's gonna be standard 'aaabbbccc'):");
            string tempUserInput = Console.ReadLine();
            if (tempUserInput != null)
            {
                // if not empty make userInput temp user input.
                userInput = tempUserInput;
            }
            else
            {
                // If empty replace with aaabbbccc
                userInput = "aaabbbccc";
            }
            Console.Clear();

            // Use method to compress the string.
            Console.WriteLine(CompressString(userInput));
        }
        public static string CompressString(string userInput)
        {
            // start initliaztion variables.
            string compressed = null;
            char currentChar = userInput[0];
            int count = 1;

            // Loop through each character in the user input, apending a space to ensure the last character is processed
            foreach (char c in userInput.Substring(1) + " ")
            {
                // If the curent character is the same as the previus one, plus one in the counter
                if (c == currentChar)
                {
                    count++;
                }
                // If the curent character is different from the previus one
                else
                {
                    // Adding the character with a count in string compressed.
                    compressed += $"{currentChar}{count}";
                    currentChar = c;
                    count = 1;
                }
            }

            // Return the original input if the compressed string is not shorter, otherwise return the compressed string
            return compressed.Length >= userInput.Length ? userInput : compressed;
        }
    }
}
