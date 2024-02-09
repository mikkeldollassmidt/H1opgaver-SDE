using System;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;

namespace Loops6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInputString = "klasdmlasmdl##MikkelOtteDollasSmidt##lkmaslkmdasldmk";

            Console.WriteLine(ExtractString(userInputString));
            Console.ReadLine();
        }

        static string ExtractString(string userInputString)
        {
            // Standard variable for extractedText
            string extractedText = null;

            // Find index of hashtags. Place a "keypoint" if first hashtags are found like the prefix in the code. IndexOf
            int start = userInputString.IndexOf("##");
            int end = userInputString.LastIndexOf("##");

            // Is hashtags found?
            if (start != -1 && end != -1 && start != end)
            {
                // extractedText string for putting in text between hashtags to extract to users console.
                extractedText = userInputString.Substring(start + 2, end - start - 2);
                return extractedText;
            }
            else
            {
                // Found no text inbetween hashtags, show error.
                return "No text in hashtags";
            }
        }
    }
}
