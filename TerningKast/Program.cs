namespace TerningKast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Standard variable for diceAmount.
            int diceAmount = 0;

            // While for error handling to startover if something fails.
            while (true)
            {
                Console.Clear();

                // User interaction.
                Console.WriteLine("How many dices should be rolled (Max: 10 dices):");
                string tempDiceAmount = Console.ReadLine();

                // Check if diceAmount is only numbers.
                if (IsNumeric(tempDiceAmount))
                {
                    // Try used to ConvertToInt and catch exceptions.
                    try
                    {
                        // If tempdiceamount converted to int is lower than 10 make diceamount into tempdiceamount.
                        if (Convert.ToInt16(tempDiceAmount) <= 10)
                        {
                            diceAmount = Convert.ToInt16(tempDiceAmount);
                        }
                        else
                        {
                            // tempdiceAmount is over 10 and the user has been redirected to startover.
                            Console.WriteLine("Dice amount can't be higher than a 10. Press ENTER to try again");
                            Console.ReadLine();
                            continue;
                        }
                    }
                    // Write out exception.
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
                else
                {
                    // Number is not numeric and the user is sent to startover.
                    Console.WriteLine("The dice amount can only be numeric. Press ENTER to try again.");
                    Console.ReadLine();
                    continue;
                }

                // list for all dice objecets.
                List<Dice> diceList = new List<Dice>();

                // For loop to add dices to dice list.
                for (int i = 0; i < diceAmount; i++)
                {
                    // new Dice object and add object to diceList
                    Dice dice = new Dice();
                    diceList.Add(dice);
                }

                // Standard variables for allSixes bool and rollCOunt.
                bool allSixes = false;
                int rollCount = 0;

                // While to keep a loop going until allSixes is false.
                while (!allSixes)
                {
                    // Set the allSixes to true, so the while loop will run after this run.
                    allSixes = true;

                    // For loop to roll the dices from the list.
                    for (int i = 0; i < diceList.Count; i++)
                    {
                        int result = diceList[i].DiceRoll();

                        // if result is not 6 break allSixes and make it false.
                        if (result != 6)
                        {
                            allSixes = false;
                            break;
                        }
                    }

                    // increase rollCount by 1.
                    rollCount++;
                }

                // Write end result.
                Console.WriteLine($"It took {rollCount} rolls for {diceList.Count} dices to roll only sixes.");
                Console.ReadLine();
            }


        }

        // IsNumeric is used to optimize how to check if a string is consiting of numbers.
        static bool IsNumeric(string input)
        {
            // used to check if a string is only consisting of numbers.
            return int.TryParse(input, out _);
        }
    }
}
