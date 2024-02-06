namespace Conditional2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Try catch for catching exceptions like overflow.
            try
            {
                // User interaction
                Console.WriteLine("Type first number:");
                int nr1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Type second number:");
                int nr2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                // Try using the method DivisibleBy2Or3 if possible.
                Console.WriteLine(DivisibleBy2Or3(nr1, nr2));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                // Catch exception and write exception information.
                Console.WriteLine(ex.Message);
            }
        }

        public static int DivisibleBy2Or3(int nr1, int nr2)
        {
            // Creating a standard variable for getting the sum and multiplied. 
            // It makes it easier when returning value.
            int sum = nr1 + nr2;
            int multiplied = nr1 * nr2;

            // Using Modulo to check if user input is divisble with 2 and 3.
            if (nr1 % 2 == 0 || nr1 % 3 == 0)
            {
                if (nr2 % 2 == 0 || nr2 % 3 == 0)
                {
                    return multiplied;
                }
                else
                {
                    return sum;
                }
            }
            // Else we're just returning sum.
            else
            {
                return sum;
            }
        }
    }
}
