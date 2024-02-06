namespace Conditional5
{
    public class Program
    {
        static void Main(string[] args)
        {
            // using try parse to catch exception. Could be overflow.
            try
            {
                // User interagation.
                Console.WriteLine("Write an integer:");
                int inputInt = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                // Try using the method.
                Console.WriteLine(IfNumberIsEven(inputInt));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        public static bool IfNumberIsEven(int inputInt)
        {
            // Checks if userInput is even with Modulo. If true, return true otherwise return false.
            if (inputInt % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
