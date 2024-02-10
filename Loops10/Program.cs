namespace Loops10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Try catch for catching exceptions as stack overflow.
            try
            {
                Console.WriteLine(ToThePowerOf(5, 5));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                // Write exception message.
                Console.Write(ex.Message);
            }

        }
        public static double ToThePowerOf(int n, int m)
        {
            // Used Math.Pow to find power of the two given integers.
            return Math.Pow(n, m);
        }
    }
}