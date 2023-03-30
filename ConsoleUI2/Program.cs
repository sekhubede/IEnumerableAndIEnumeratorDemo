using System;
using System.Collections;
using System.Collections.Generic;

using static System.Console;

namespace ConsoleUI2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a generic IEnumerable variable that takes any collection of type int
            // We will use this variable to store the collections taht will get returned by the GetCollection() method.

            IEnumerable<int> unknownCollection;

            unknownCollection = GetCollection(1);
            WriteLine("This was a List<int>");
            // foreach number in the collection we got back from GetCollection(1);
            foreach (int num in unknownCollection)
            {
                Write(num + " ");
            }

            // New line.
            WriteLine();

            // Call GetCollection() with option = 2 which will return a Queue<int>
            // but we will store it in the base type of generic collections.
            unknownCollection = GetCollection(2);
            WriteLine("This was a Queue<itn>");
            // foreach number in the collectiion we got back from GetColletion(2);
            foreach (int num in unknownCollection)
            {
                Write(num + " ");
            }

            // New line;
            WriteLine();

            // Call GerCollection() with option = 5 which will return an array int[]
            // but we will store it in the base type of generic collections.
            unknownCollection= GetCollection(5);
            WriteLine("This was an array of int");
            // foreach number in the collection we got back from GerCollection(5);
            foreach (int num in unknownCollection)
            {
                Write(num + " ");
            }


            ReadKey(true);
        }

        static IEnumerable<int> GetCollection(int option)
        {
            // Create a list of numbers and initialize it.
            List<int> numbersList = new List<int>() { 1, 2, 3, 4 , 5};

            Queue<int> numbersQueue = new Queue<int>();
            // Add values to the queue.
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            // If the option is 1.
            if (option == 1)
            {
                // Return the list of type List<int>.
                return numbersList;

            } // If the option is 2.
            else if (option == 2)
            {
                // Return the queue of type<int>.
                return numbersQueue;
            } // Otherwise
            else
            {
                // Return an array of numbers intialized with some numbers.
                return new int[] { 11, 12, 13, 14, 15 };
            }

        }
    }
}
