using System;

using static System.Console;

using ShelterLibrary;

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
            /// - Your collection represents a massive database table,
            /// you don't want to copy the entire thing into memory and cause performance issues in your application.
            /// When it is not recommended to use the IEnumerable interface:
            /// You need the results right away and are pssibly mutating / editing the objects later on. 
            /// In this case, it is better to use an Array or a List.
        
        static void Main(string[] args)
        {
            
            DogShelter shelter = new DogShelter();

            foreach (Dog dog in shelter)
            {
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }
            ReadKey(true);
        }
    }
}
