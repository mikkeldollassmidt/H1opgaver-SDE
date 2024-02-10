namespace Loops8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I don't know if it's a mistake in the homework, but i found that the sum in the homework did'nt match mine
            // I've used a sum calculator to find the sum and it's the same as i get in my project here.

            // Using method to find sum and average with two numbers.
            Console.WriteLine(SumAndAverage(-10,0));
            Console.ReadLine();
        }
        public static string SumAndAverage(int n, int m)
        {
            // Standard variables for calculating sum and average
            double sum = 0;
            int count = 0;

            // For loop for finding sum
            for (double i = n; i <= m; i++)
            {
                sum += i;
                count++;
            }

            // Formular for finding average
            double average = sum / count;

            // Return string.
            return $"Sum: {sum}, Average: {average}";
        }
    }
}