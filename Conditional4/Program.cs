namespace Conditional4
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create the userinputArray
            int[] userInputArray = new int[3] { 0, 0, 0 };

            // User interaction
            Console.WriteLine("Write first number:");
            userInputArray[0] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Write second number:");
            userInputArray[1] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Write last number:");
            userInputArray[2] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            // Use method to check if userInputArray is greater than third one.
            Console.WriteLine(IfGreaterThanThirdOne(userInputArray));
            Console.ReadLine();
        }

        public static bool IfGreaterThanThirdOne(int[] userInputArray)
        {
            // Standard bool is false.
            bool biggerThanSum = false;

            // If userInput1 plus userInput2 is smaller than third userInput go to next if, where it checks if it smaller if multiplied.
            if (userInputArray[0] + userInputArray[1] < userInputArray[2])
            {
                if (userInputArray[0] * userInputArray[1] < userInputArray[2])
                {
                    biggerThanSum = false;
                } else
                {
                    biggerThanSum = true;
                }
            }
            else
            {
                biggerThanSum = true;
            }
            // Return biggerThanSum 
            return biggerThanSum;
        }
    }
}
