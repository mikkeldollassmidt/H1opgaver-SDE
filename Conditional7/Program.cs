namespace Conditional7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // User interaction:
                Console.WriteLine("Write a number:");
                double inputNumber = Convert.ToDouble(Console.ReadLine());
                Console.Clear();

                // Try method and return a result.
                Console.WriteLine(PositiveNegativeOrZero(inputNumber));
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                // Catch exception and handle.
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }

        public static string PositiveNegativeOrZero(double inputNumber)
        {
            // Check if number is larger than 0 and return positive.
            if (inputNumber > 0)
            {
                return "Positive";
            }
            // Check if number is equal to 0 return zero.
            else if (inputNumber == 0)
            {
                return "Zero";
            // Else return negative, then it must be negative.
            } else
            {
                return "Negative";
            }
        }
    }
}
