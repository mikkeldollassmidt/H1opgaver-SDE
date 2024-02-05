namespace Basic3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interact with user inputs
            Console.WriteLine("Number 1:");
            int nr1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Number 2:");
            int nr2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine(ElementaryOperations(nr1, nr2));
            Console.ReadLine();
        }

        public static string ElementaryOperations(int nr1, int nr2)
        {
            // Formulars for addition, subtraction and multiplication.
            int equalAddition = nr1 + nr2;
            int equalSubtraction = nr1 - nr2;
            int equalMultiplication = nr1 * nr2;

            // Devision. Casts integer into double, so i get the preferred result.
            double equalDivision = (double)nr1 / nr2;

            // Making a string to return. (Front end)
            string equalString = equalAddition.ToString("0") + ", " + equalSubtraction.ToString("0") + ", " + equalMultiplication.ToString("0.00") + ", " + equalDivision.ToString("0.00");

            return (equalString);
        }
    }
}
