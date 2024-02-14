using System;

namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User interaction and creating variables.
            Console.WriteLine("Enter array value amount:");
            int inputArraySizeAmount = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            int[] randomArray = CreateRandomArray(inputArraySizeAmount);
            Console.WriteLine("Original array:");
            Console.WriteLine(ArrayToString(randomArray) + "\n");

            Console.WriteLine("Enter rotation times:");
            int rotationTimes = Convert.ToInt32(Console.ReadLine());

            int[] rotatedArr = RotateArray(randomArray, rotationTimes);
            Console.WriteLine("Rotated array:");
            Console.WriteLine(ArrayToString(rotatedArr));
        }

        // Method for rotating array.
        public static int[] RotateArray(int[] randomArray, int rotationTimes)
        {
            // Standard variables for length of the array (n) and the array thats gonna get returned called rotatedArray.
            int n = randomArray.Length;
            int[] rotatedArray = new int[n];

            // For loop that rotate the array and puts value in the rotatedArray from the randomArray from Main. This makes sure that when the new index goes past the size of the array, it goes back to the start.
            for (int i = 0; i < n; i++)
            {
                rotatedArray[(i + rotationTimes) % n] = randomArray[i];
            }

            return rotatedArray;
        }

        // Method used to create a random array with length from user and values random from -1000 to 1000.
        public static int[] CreateRandomArray(int inputArraySizeAmount)
        {
            int[] arr = new int[inputArraySizeAmount];
            Random random = new Random();

            for (int i = 0; i < inputArraySizeAmount; i++)
            {
                arr[i] = random.Next(-1000, 1000);
            }

            return arr;
        }

        // Method to make an array to string.
        public static string ArrayToString(int[] arr)
        {
            return string.Join(", ", arr);
        }
    }
}
