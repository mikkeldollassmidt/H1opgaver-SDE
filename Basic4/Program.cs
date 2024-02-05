namespace Basic4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 arithmetic operations
            int ao1 = 9 / 3;
            int ao2 = 16 - 1;

            // Use IsResultTheSame for checking if arithmetic operations are equal to eachother.
            if (IsResultTheSame(ao1, ao2) == true)
            {
                // result true? write true.
                Console.WriteLine("True");
            } 
            else
            {
                // result false? write false.
                Console.WriteLine("False");
            }
            Console.ReadLine();
        }
        public static bool IsResultTheSame(int ao1, int ao2)
        {
            // If match return true or false.
            if (ao1 == ao2)
            {  return true; }
            else
            {
                return false;
            }
        }
    }
}
