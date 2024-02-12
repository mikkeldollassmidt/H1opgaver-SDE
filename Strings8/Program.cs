namespace Strings8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user interaction and creating and putting in variables with user input.
            Console.WriteLine("Write a sentence:");
            string userInput = Console.ReadLine();
            Console.Clear();

            // Using method to sortCharacters to descended.
            Console.WriteLine(SortCharactersDescending(userInput));
        }
        public static string SortCharactersDescending(string userInput)
        {
            // Using this method it makes userInput into chars and using library OrderByDescending char to char into array and writes out in a string with new string. Using lambda to calculate inline.
            return new string(userInput.OrderByDescending(c => c).ToArray());
        }
    }
}
