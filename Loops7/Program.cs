namespace Loops7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Two given letters that will use the method to create a sequence within the two given letters.
            Console.WriteLine(FullSequenceOfLetters("d", "s"));
            Console.ReadLine();
        }

        public static string FullSequenceOfLetters(string first, string second)
        {
            // String for capturing every character within the given interval from user.
            string outputSequence = null;

            // Check if characters given from user, if they're 1 character long.
            if (first.Length != 1 || second.Length != 1 || first[0] >= second[0])
            {
                Console.WriteLine("No letters found or too long letters used. (Use only 1 character).");
            }
            else
            {
                // For loop that takes first character from first and second string. C = First(String), comparing to second, so c goes from first string to the second until they match.
                // Every time the for loop runs, sequence gets the value from c, so we can create a sequence with all characters in between.
                for (char c = first[0]; c <= second[0]; c++)
                {
                    outputSequence += c;
                }
            }

            // Return sequence string.
            return outputSequence;
        }
    }
}