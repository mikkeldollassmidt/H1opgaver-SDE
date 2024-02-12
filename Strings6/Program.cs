namespace Strings6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User interaction
            Console.WriteLine("Write a sentence (Example: Hello my name is..):");
            string userInput = Console.ReadLine();
            Console.Clear();

            // Using method to revert words order.
            Console.WriteLine(RevertWordsOrder(userInput));

        }
        public static string RevertWordsOrder(string userInput)
        {
            // Using Libraries to split and reverse string in a array. After splitting and reversing, we're joining the array into a string again.
            return string.Join(" ", userInput.Split(' ').Reverse());
        }
    }
}
