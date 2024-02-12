namespace Strings7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user interaction, creating variables and putting user input inside of them.
            Console.WriteLine("Write a sentence:");
            string userWordInput = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Check occurrences of word:");
            string userLookupWord = Console.ReadLine();
            Console.Clear();

            // Use method to get count of occurrences in userWordinput of userLookupWord.
            Console.WriteLine(HowManyOccurrences(userWordInput, userLookupWord));
        }
        public static int HowManyOccurrences(string userWordInput, string userLookupWord)
        {
            // Int to split where the userLookupWord is and count length.
            int countOccurrences = userWordInput.Split(userLookupWord).Length - 1;

            // Return occurrences as int.
            return countOccurrences;
        }
    }
}
