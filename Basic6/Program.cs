namespace Basic6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user interaction
            Console.WriteLine("Find cube of:");
            double input = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            // Use TheCubeOf method to find cube of the users input.
            Console.WriteLine(TheCubeOf(input));
            Console.ReadLine();
        }

        public static double TheCubeOf(double input)
        {
            // Cube formular. Input^3 
            double findCube = input * input * input;
            return findCube;
        }
    }
}
