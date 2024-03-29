﻿namespace Loops9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // call the method.
            Console.WriteLine(DrawTriangle());
        }

        public static string DrawTriangle()
        {
            // Loop for each row of the Christmas tree
            for (int i = 0; i < 8; i++)
            {
                // Calculate the number of spaces to align the tree
                int numberOfSpaces = 8 - i - 1;

                // Print spaces to align the tree
                for (int j = 0; j < numberOfSpaces; j++)
                {
                    Console.Write(" ");
                }

                // Loop to print * for each row
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    // use modulo to check if i is even or k is even.
                    if ((i % 2 == 0) || (k % 2 == 0))
                    {
                        // Set text color to green for every second row
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("*");
                        // Reset the color to standard (white).
                        Console.ResetColor();
                    }
                    else
                    {
                        // "or" set the text color to red for other rows.
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("*");
                        Console.ResetColor();
                    }
                }
                // Move to the next line for the next row
                Console.WriteLine();
            }
            // Pause the console so the tree is visible
            Console.ReadLine();

            // Needed to return something. So nothings in the return string.
            return "";
        }
    }
}
