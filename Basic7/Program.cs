namespace Basic7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user interaction
            Console.WriteLine("Write a number: ");
            int nr1 = Convert.ToInt32 (Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Write next number:");
            int nr2 = Convert.ToInt32 (Console.ReadLine());
            Console.Clear();

            // Use method SwapTwoNumbers to swap both numbers and return string and show.
            Console.WriteLine(SwapTwoNumbers(nr1, nr2));
            Console.ReadLine();
        }

        public static string SwapTwoNumbers(int nr1, int nr2)
        {
            // Create the end return string to the Before the swap numbers.
            string returnString = "Before: a = " + nr1 + ", b = " + nr2;

            // Swap numbers by making a temporary variable to keep nr1 and making nr1 get the value of nr2.
            int temp = nr1;
            nr1 = nr2;
            nr2 = temp;

            // Add to returnString After swapping.
            returnString += "; After: a = " + nr1 + ", b = " + nr2;

            // return string.
            return (returnString);
        }
    }
}
