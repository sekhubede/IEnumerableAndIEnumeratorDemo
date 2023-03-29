using System;

namespace ConsoleUI
{
    internal class Program
    {
            // 1. IEnumerable <T> for generic collections.
            // 2. IEnumerable for non generic collections.

            /// <summary>
            /// IEnumerable<T> contains a single method that you must implement when implementing this interface;
            /// GetEnumerator(), which returns an IEnumerator<T> object.
            /// The returned IEnumerator<T> provides the ability to interate through the collection
            /// by exposing a Current property that points at the object we are currently at in the collecion.
            /// </summary>
            
            
            /// When it is recommended to use the IEnumerable interface:... 
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
        }
    }
}
