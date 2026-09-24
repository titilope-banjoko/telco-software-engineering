using System;
using oop;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            // First instance
            //User usr = new User();
            //// User = class and datatype
            //// usr = object
            //// User usr = new User(); = instance of a class
            //usr.firstName = "Titilope";
            //usr.lastName = "Banjoko";
            //usr.age = 17;
            //usr.complexion = "Brown";


            // Constructor - 2
            // Create a new user object
            //User usr1 = new User();
            //usr1.firstName = "Titilore";
            //usr1.lastName = "Banjoko";
            //usr1.age = 7;


            //// Second instance
            //User usr2 = new User();
            //usr2.firstName = "Titilayo";
            //usr2.lastName = "Banjoko";
            //usr2.age = 5;

            // Constructor - 1
            User usr3 = new User("Titilope", "Banjoko", 12);



            Console.WriteLine("First Name: " + usr3.firstName);
            Console.WriteLine("Last Name: " + usr3.lastName);
            Console.WriteLine("Age: " + usr3.age);


            Console.ReadLine();
        }
    }
}