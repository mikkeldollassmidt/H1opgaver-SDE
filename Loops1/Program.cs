namespace Loops1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // This for loop is y axis. 10 numbers vertically. Bigger than 11, because of i is = 1; Could've used <= 10.
            for (int i = 1; i < 11; i++)
            {
                // This for loop is x axis 10 numbers horizontal. Bigger than 11, because of j is = 1. Could've used <= 10.
                for (int j = 1; j < 11; j++)
                {
                    // Calculate numberWrite before writing. Using PadLeft to make the string have padding to the left, that will make the table line up perfectly.
                    int numberWrite = i * j;
                    Console.Write(numberWrite.ToString().PadLeft(5));
                }
                // Next line
                Console.Write("\r\n");
            }
        }
    }
}
