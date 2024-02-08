using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Loops5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Try catch for catching Exceptions like int overflow.
            try
            {
                // user interaction
                Console.Write("Choose the last number in a range of prime numbers: 1-");
                int userInputLastRangeNumber = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                // try using method to show result.
                Console.WriteLine(SieveOfEratosthenes(userInputLastRangeNumber));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        /// <summary>
        /// 
        ///  I took some inspiration for the SieveOfEratosthenes method from:
        ///  https://khalidabuhakmeh.com/find-prime-numbers-with-csharp-9
        /// 
        /// </summary>
        public static string SieveOfEratosthenes(int userInputLastRangeNumber)
        {

            // standard string for output in Main
            string primeNumbersInInterval = "";

            // loop through numbers starting from 2 up to the userInputLastRangeNumber
            for (int numberToCheck = 2; numberToCheck <= userInputLastRangeNumber; numberToCheck++)
            {
                // Standard bool to test if currentNumber is a PrimeNumber (PN)
                bool isPN = true;

                // for loop checking from 2 and up to userInputLastRangeNumbers divisibility
                for (int possibleFactor = 2; possibleFactor < numberToCheck; possibleFactor++)
                {
                    // if for checking if numberToCheck is divisible by smaller numbers, if statements are correct make the IsPN false.
                    if (numberToCheck % possibleFactor == 0)
                    {
                        isPN = false;
                        break;
                    }
                }

                // if IsPN is true, add currentNumber into primeNumbersInInterval
                if (isPN)
                {
                    primeNumbersInInterval += numberToCheck + ", ";
                }
            }

            // return restult string.
            return primeNumbersInInterval;
        }

    }

}

