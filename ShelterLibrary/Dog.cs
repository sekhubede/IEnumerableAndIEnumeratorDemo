using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelterLibrary
{
    public class Dog
    {
        // The name of the dog.
        public string Name { get; set; }
        // Is this a naughty dog.
        public bool IsNaughtyDog { get; set; }
        // Simple constructor.
        public Dog(string name, bool isNaughtyDog) 
        {
            this.Name = name;
            this.IsNaughtyDog = isNaughtyDog;
        }

        // This method will print how many treats the dog received.
        public void GiveTreat(int numberOfTreats)
        {
            // Print a message containing the number of treats and the name of the dog.
            Console.WriteLine($"Dog: {Name} said wuoff {numberOfTreats}!.");
        }
    }
}
