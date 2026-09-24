using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class User
    {
        // This is a specification or blueprint otherwise known as Class 
        internal string firstName;
        internal string lastName;
        internal int age;


        // Constructor - writing fewer words for an object/constructs an abject
        // Contructor - 1
        // Constructors can log to a database, ta;k to a wbsite, open db connection
        internal User(string FirstName, string LastName, int Age)
        {
            Console.WriteLine("Setting up a new user ...");
            firstName = FirstName;
            lastName = LastName;
            age = Age;
        }

        //internal User() // Constructor - 2
        //{

        //}

        // Object method
        internal bool isRetired()
        {
            return (age >= 66);
        }
    }
}
