using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace IEnumerableChallenge
{
    internal class Program
    {
        /// <summary>
        /// Challenge:
        /// 
        /// Create Contact and PhoneBook classes in the right way
        /// that will allow you to run the Main method provided.
        /// 
        /// You have to use this list of Contact:
        /// Contacts = new List<Contact>{
        ///     new Contact("Andre", "435797087"),
        ///     new Contact("Lisa", "435677087"),
        ///     new Contact("Dine", "3457697087"),
        ///     new Contact("Sofi", "4367697087")
        ///     };
        ///     
        /// The method Call should print "Calling to X. Phone number is Y"
        /// where X is a name and Y is a phone number.
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
           
            PhoneBook MyPhoneBook = new PhoneBook();

            foreach (Contact contact in MyPhoneBook)
            {
                contact.Call();
            }

            ReadKey(true);
        }

    }

    /// <summary>
    /// Solution
    /// </summary>
    /// 
    class PhoneBook : IEnumerable<Contact> 
    {
        
        // List of type List<Contact>
        public List<Contact> contacts;

        // This constructor will initalize the contacts list with some values.
        public PhoneBook()
        {
            contacts = new List<Contact>()
            {
                new Contact("Andre", "435797087"),
                new Contact("Lisa", "435677087"),
                new Contact("Dine", "3457697087"),
                new Contact("Sofi", "4367697087")
            };
        }

        public IEnumerator<Contact> GetEnumerator()
        {
            return contacts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)contacts).GetEnumerator();
        }
    }

    class Contact
    {
        // The contact name.
        public string Name { get; set; }
        // The contact number.
        public string  Number { get; set; }

        // Simple constructor.
        public Contact(string contactName, string contactNumber) 
        {
            this.Name = contactName;
            this.Number = contactNumber;
        
        }

        // This method will print a calling message.
        public void Call()
        {
            // Print a message containing the name and number.
            WriteLine($"Calling to {Name}. Phone number is {Number}");
        }
    }
}
