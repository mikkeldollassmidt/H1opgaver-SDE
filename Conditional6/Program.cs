namespace Conditional6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Creating a standard int array with 3 numbers.
                int[] userInputArray = new int[3] { 0, 0, 0 };

                // User interaction:
                Console.WriteLine("Write first number:");
                userInputArray[0] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Write second number:");
                userInputArray[1] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Write third number:");
                userInputArray[2] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                // Try using method and write result.
                Console.WriteLine(IfSortedAscending(userInputArray));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static bool IfSortedAscending(int[] userInputArray)
        {
            // For loop to check if currently counted is bigger than the number counted before. So it always checks back if the number behind is bigger than the currently number.
            for (int i = 1; i < userInputArray.Length; i++)
            {
                // Example: If userInputArray[1] is bigger than userInputArray[2] go on, but if not return false.
                if (userInputArray[i - 1] > userInputArray[i])
                {
                    return false;
                }

            }
            return true;
        }
    }
}
