namespace Conditional1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User interaction
            Console.WriteLine("Write number:");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            // Use method AbsoluteValue to find absolute value from user input.
            Console.WriteLine("Absolute value: " + AbsoluteValue(input));
            Console.ReadLine();
        }

        public static int AbsoluteValue(int input)
        {
            // Use Math.Abs to make the input absolute.
            int absoluteInput = Math.Abs(input);
            return absoluteInput;
        }
    }
}
