using System;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            User usr = new User();
            // User = class and datatype
            // usr = object
            // User usr = new User(); = instance of a class
            usr.firstName = "Titilope";
            usr.lastName = "Banjoko";
            usr.age = 17;
            usr.complexion = "Brown";

            User usr1 = new User();

            User usr2 = new User();

            Console.WriteLine("First Name: " + usr.firstName);
            Console.WriteLine("Last Name: " + usr.lastName);
            Console.WriteLine("Age: " + usr.age);

            Console.ReadLine();
        }
    }
}