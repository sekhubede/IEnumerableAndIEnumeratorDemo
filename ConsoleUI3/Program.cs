 using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace ConsoleUI3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A list of type List<int> intialized with some number.
            List<int> numberList = new List<int>() { 8, 6, 2 };

            // An array of type int[] intialized with some numbers.
            int[] numberArray = new int[] { 1, 7, 1, 3 };

            // New line.
            WriteLine();

            // Call CollectionSum() and pass the list to it.
            CollectionSum(numberList);

            // New line.
            WriteLine();

            // Call CollectionSum() and pass the array to it.
            CollectionSum(numberArray);
        }

        static void CollectionSum(IEnumerable<int> anyCollection) 
        {
            // Sum variable to store the sum of the numbers in anyCollection.
            int sum = 0;

            // foreach number in the collection passed to this method.
            foreach (int num in anyCollection)
            {
                // Add the num value to sum.
                sum += num;
            }

            Write($"Sum is {sum}");
        }
    }
}
