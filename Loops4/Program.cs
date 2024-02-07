namespace Loops4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Try catch to show exceptions.
            try
            {
                int[] userInputArray = new int[9];

                // User interaction.
                for (int i = 0; i < 9; i++)
                {
                    Console.WriteLine("Write a number:");

                    // CurremtUserInput is capturing the number the user types, so we can handle what to do with it. Error handlings, change value and so on.
                    int currentUserInput = Convert.ToInt32(Console.ReadLine());

                    // If currentUserInput is negative, show error message, if not save value from currentUserInput in userInputArray[i]
                    if (currentUserInput >= 0)
                    {
                        userInputArray[i] = currentUserInput;
                        Console.Clear();
                    }
                    else
                    {
                        // If negative number, replace with 0;
                        Console.WriteLine("Negative numbers ain't allowed. We replaced your number with 0.\r\nPress 'ENTER' to continue.");
                        userInputArray[i] = 0;
                        Console.ReadLine();
                        Console.Clear();
                    }

                }

                // For loop, for showing what the user had written in the array.
                for (int j = 0; j < userInputArray.Length; j++)
                {
                    // Used interpolated string, so it got easier when writing, what the console.write should show.
                    Console.Write($"{userInputArray[j]}, ");
                }

                // also used interpolated string here, so we could go down a line for design.
                Console.WriteLine($"\r\n{ThreeIncreasingAdjacent(userInputArray)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static bool ThreeIncreasingAdjacent(int[] userInputArray)
        {
            // standard variable for counting times numbers is only 1 number higher than the previous.
            int timesCountingOneUp = 0;

            // for loop to run a check through all of userInputArrays values.
            for (int i = 1; i < userInputArray.Length; i++)
            {
                // If for check if current number in array is up 1 number from the last array number.
                if (userInputArray[i] == userInputArray[i - 1] + 1)
                {
                    // Count up one, if the statements is true.
                    timesCountingOneUp++;
                    if (timesCountingOneUp == 3)
                    {
                        // return true, if timesCountingUp is 3.
                        return true;
                    }
                }
                else
                {
                    // If times counting up breaks, reset to 1.
                    timesCountingOneUp = 1;
                }
            }
            // Return false, if nothing matches up with if statements.
            return false;
        }

    }
}
