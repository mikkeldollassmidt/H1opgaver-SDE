namespace Basic1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tal 1:");
            int nr1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Tal 2:");
            int nr2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Tal 3:");
            int nr3 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine(AddAndMultiply(nr1, nr2, nr3));
            Console.ReadLine();
        }
        public static int AddAndMultiply(int nr1, int nr2, int nr3)
        {
            int equalAddedAndMultiplied = (nr1 + nr2) * nr3;
            return equalAddedAndMultiplied;
        }
    }
}
