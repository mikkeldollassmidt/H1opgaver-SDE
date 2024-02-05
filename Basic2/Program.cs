namespace Basic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Capture user input in a double.
            Console.WriteLine("Celsius:");
            double celsiusInput = Convert.ToDouble(Console.ReadLine());

            // If statement for user input not to be below 271,15
            if (celsiusInput > -271.15)
            {
                // Convert in method. Write result.
                Console.Clear();
                Console.WriteLine(CtoF(celsiusInput));
            } else
            {
                // Handle if input is below 271,15
                Console.Clear();
                Console.WriteLine("Temperature below absolute zero!");
            }
        }

        public static double CtoF(double c)
        {
            // Convert celsius to fahrenheit formluar
            double converter = (c * 1.8) + 32;

            // Return converter.
            return converter;
        }
    }
}
