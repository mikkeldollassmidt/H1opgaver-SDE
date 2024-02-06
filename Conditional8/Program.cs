namespace Conditional8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // User interaction:
                Console.WriteLine("Write a year (yyyy):");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                // Trying to use IfYearIsLeap method to check if userInput (year) is a leap year.
                Console.WriteLine(IfYearIsLeap(year));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                // Show exception if exception is catched.
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }

        public static bool IfYearIsLeap(int year)
        {
            // Using DateTime.IsLeapYear method to check if year is 2000, 2004, 2008.... And so on.
            if (DateTime.IsLeapYear(year))
            {
                // If true, return true.
                return true;
            }
             else
            {
                // Else return false.
                return false;
            }
        }
    }
}
