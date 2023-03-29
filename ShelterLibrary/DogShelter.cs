using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelterLibrary
{
    // A class named DogShelter this class contains a generic collection of type Dog
    // objects of this class can't be used inside a for each loop because it lacks an implementtion of the IEnumerable interface.
    public class DogShelter : IEnumerable<Dog>
    {
        // List of type List<Dog>
        public List<Dog> dogs;
        // This constructor will initialize the dogs list with some values.
        public DogShelter()
        {
            dogs = new List<Dog>()
            {
                new Dog("Casper",false),
                new Dog("Sif", true),
                new Dog("Oreo",false),
                new Dog("Pixel",false),
            };
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
