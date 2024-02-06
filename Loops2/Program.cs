namespace Loops2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Standard int with max array count of 5.
                int[] userInputArray = new int[5] { 0, 0, 0, 0, 0 };

                // For loop for user interaction, so the user can type in 5 different numbers for the array.
                for (int i = 0; i < 5; i++)
                {
                    // Checks if the for loop is in the first round to send the start message.
                    if (i == 0)
                    {
                        Console.WriteLine("Write a number:");
                        userInputArray[i] = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                    }
                    // Else change WriteLine..
                    else
                    {
                        Console.WriteLine("Write another number:");
                        userInputArray[i] = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                    }

                }

                // Try using the method to find biggest number in userInputArray.
                Console.WriteLine(TheBiggestNumber(userInputArray));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public static int TheBiggestNumber(int[] userInputArray)
        {
            // Creating a int to make first number in users array the highest, so the for can compare with other numbers in array.
            int biggestNumber = userInputArray[0];

            for (int i = 0; i < userInputArray.Length; i++)
            {
                // If userInputArray is bigger than the biggestNumber, make the userInputArray the biggestNumber
                if (userInputArray[i] > biggestNumber)
                {
                    biggestNumber = userInputArray[i];
                }
            }
            // Return biggestNumber
            return biggestNumber;
        }
    }
}
