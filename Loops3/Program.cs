using System.Runtime.CompilerServices;

namespace Loops3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Standard userInputArray.
                int[] userInputArray = new int[10];

                // User Interaction:

                // For loop for the array length.
                for (int i = 0; i < userInputArray.Length; i++)
                {
                    Console.WriteLine("Write a number: (1 digit number)");
                    // CheckInputNumber is capturing the number written by the user, to check if the number is smaller than 2 digits and a positive number.
                    int checkInputNumber = Convert.ToInt32(Console.ReadLine());
                    if (checkInputNumber < 10 && checkInputNumber >= 0)
                    {
                        userInputArray[i] = checkInputNumber;
                    }
                    else
                    {
                        // If the number is more than 1 digit or a negative number, then just make the number 0.
                        Console.WriteLine("You can't type numbers that are more than 1 digit long or negative numbers.");

                        // Show the "We replaced..." message in green and reset color.
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("We replaced your number with 0.");
                        Console.ForegroundColor= ConsoleColor.White;

                        Console.ReadLine();
                        userInputArray[i] = 0;
                    }
                    Console.Clear();
                }
                // try method and write on console.
                Console.WriteLine(Two7sNextToEachOther(userInputArray));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static int Two7sNextToEachOther(int[] userInputArray)
        {
            // Standard bool set to false.
            bool firstSevenHit = false;
            // Counter for doubleSevens.
            int doubleSevenCounter = 0;

            // For loop that run based on the array length.
            for (int i = 0; i < userInputArray.Length;i++)
            {
                // If one seven is seen, make firstSevenHit true,
                if (userInputArray[i] == 7)
                {
                    // Check if another seven is seen, then ++ the seven counter.
                    if (userInputArray[i] == 7 && firstSevenHit == true)
                    {
                        doubleSevenCounter++;
                    }
                    else
                    {
                        firstSevenHit = false;
                    }
                    firstSevenHit = true;
                }
                else
                {
                    firstSevenHit = false;
                }
            }
            // Returning doubleSevenCounter.
            return doubleSevenCounter;
        }
    }
}
