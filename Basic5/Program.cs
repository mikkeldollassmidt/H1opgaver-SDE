namespace Basic5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User interaction
            Console.WriteLine("Write first number:");
            int nr1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Write second number:");
            int nr2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Write third number:");
            int nr3 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            // write and use ModuloOperations method to calculate end result.
            Console.WriteLine("= " + ModuloOperations(nr1, nr2, nr3));
            Console.ReadLine();
        }

        public static int ModuloOperations(int nr1, int nr2, int nr3)
        {
            // Modulo of the first two.
            int firstNumberModulo = nr1 % nr2;

            // Modulo of first modulo and last number given.
            int lastNumberModulo = firstNumberModulo % nr3;

            // Return end result.
            return lastNumberModulo;
        }
    }
}
