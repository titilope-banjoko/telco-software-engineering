namespace FirstProgram
{
    internal class Program
    {
        //static void Main(string[] args)
        //{

        //string firstName;
        //string lastName;
        //int age;
        //int weigth;
        //float height1 = 3.50f;
        //double height;
        //decimal height3 = 8.8m; //used for money transactions
        //bool isYourFirstCar;
        //char grade;
        //string example;

        //firstName = "Titilope";
        //lastName = "Banjoko";
        //age = 42;
        //weigth = 72;
        //height = 5.9;
        //isYourFirstCar = true;
        //grade = 'A';
        //example = "The best character is Titilope Banjoko";

        //string sub = firstName.Substring(0, 4);
        //string rep = firstName.Replace("Titilope", "Ayodeji");

        //C# is both strongly typed and statically typed language

        //Console.WriteLine(firstName + " " + lastName);
        //Console.WriteLine(sub);
        //Console.WriteLine(example.Length);
        //Console.WriteLine(firstName.Replace("Titilope", "Ayodeji"));
        //Console.WriteLine(age);
        //Console.WriteLine(weigth);
        //Console.WriteLine(height);
        //Console.WriteLine(isYourFirstCar);
        //Console.WriteLine(grade);

        //int result;

        //result = 5 + 4; /when using division, let one be decimal

        //Console.WriteLine(result);

        //Console.ReadLine();

        //Console.WriteLine("What is your name?");

        //string result = Console.ReadLine();

        //Console.WriteLine("Hello " + result + "!");

        //Console.ReadLine();


        //Exercise 1
        //Console.WriteLine("Welcome to our number multiplier!");
        //Console.WriteLine("What is your first number?");
        //int firstNumber = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("What is your second number?");
        //int secondNumber = Convert.ToInt32(Console.ReadLine());

        //int result = firstNumber * secondNumber;

        //Console.WriteLine("The result is: " + result + ".");

        //Console.ReadLine();


        //2.1 Methods
        //Without return

        //static void Main(string[] args)
        //{
        //    sayHelloWorld();

        //    Console.ReadLine();
        //}

        //static void sayHelloWorld()
        //{
        //    Console.WriteLine("Hello World!");
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("What is your name?");
        //    string nameOfTheUser = Console.ReadLine();

        //    Console.WriteLine("How old are you?");
        //    int age = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Do you have a car?");
        //    Console.WriteLine("Input 1 if you do and 0 id not");
        //    //bool doYouHaveACar = Convert.ToBoolean(Console.ReadLine());

        //    sayHelloUser(nameOfTheUser, age);

        //    Console.ReadLine();
        //}

        //static void sayHelloUser(string name, int age)
        //{
        //    Console.WriteLine("Hello " + name);
        //    Console.WriteLine("Your age is " + age);
        //}

        //methods with return
        //static void Main(string[] args)
        //{
        //    string name = askForUserName();

        //    Console.WriteLine("Hello " + name)

        //    Console.ReadLine()
        //}

        //static string askForUserName()
        //{
        //    Console.WriteLine("What is your name?");
        //    string nameOfTheUser = Console.ReadLine();
        //    return nameOfTheUser;
        //}

        //methods overloading

        /*
         * Nultiline comment - always at the top of the page
         * 
         * Author: Titilope Banjoko
         * Summary: Telecom Software Engineer 
         */

        /// <summary>
        /// just type 3 forward slashes and it generate a template
        /// XML Summary tags
        /// </summary>
        /// <return></returm>
        //static void Main(string[] args)
        //{
        //    int num1;
        //    int num2;

        //    num1 = 6;
        //    num2 = 16;

        //    int result = Add(num1, num2);

        //    Console.WriteLine("");

        //    Console.ReadLine();
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        //static int Add(int num1, int num2)
        //{
        //    return (num1 + num2);
        //}

        //static double Add(double num1, double num2)
        //{
        //    return (num1 + num2);
        //}


        // If and Else If
        //static void Main(string[] args)
        //{
        //    // Ask for the user's name
        //    Console.WriteLine("What is your name");
        //    string name = Console.ReadLine();

        //    //bool isBob = (name == "bob");

        //    // Are you Bob?
        //    if (name == "bob")
        //    //{ if you have one line of action, then the braces are optional
        //        Console.WriteLine("Hey Bob! You are amazing");
        //    //}
        //    else if (name == "henry")
        //    //{
        //        Console.WriteLine("Hey Henry! You are so amazing");
        //    //}
        //    else if (name == "titilope")
        //    //{
        //        Console.WriteLine("Hey Titilope! You are so amazing");
        //    //}
        //    else
        //    //{
        //        Console.WriteLine("Hey random person");
        //    //}

        //    // Keep window open
        //    Console.ReadLine();
        //}


        // Equality and Inequality Operations
        //static void Main(string[] args)
        //{
        //    // Ask for the user's name
        //    Console.WriteLine("What is your name");
        //    string name = Console.ReadLine();

        //    // Are you Bob?
        //    // != means not equal to while == means equal to

        //    if (name == "bob")
        //    { 
        //        //{ if you have one line of action, then the braces are optional
        //        Console.WriteLine("Hey Bob! You are amazing");
        //    }

        //    Console.ReadLine();
        //}


        // Comparison Operators
        //static void Main(string[] args)
        //{
        //    // Ask for the user's name
        //    Console.WriteLine("Type a number between 1 and 2");
        //    int num = Convert.ToInt32(Console.ReadLine());

        //    if (num <= 5) // Condition
        //    {
        //        Console.WriteLine("You picked a low number"); // Action
        //    }
        //    else
        //    {
        //        Console.WriteLine("You picked a high number");
        //    }


        //        // Keeo the CLI open!
        //        Console.ReadLine();
        //}


        // Boolean Operators
        //static void Main(string[] args)
        //{
        //    // Ask for the user's name
        //    Console.WriteLine("Type a number between 1 and 10");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    if (number == 5 || number == 7 ) // Condition (|| = OR )
        //    {
        //        Console.WriteLine("You have won"); // Action
        //    }
        //    else if( number != 2 && number != 7 )
        //    {
        //        Console.WriteLine("You have lost");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Try again");
        //    }


        //    // Keep the CLI open!
        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    // Ask for the user's name
        //    Console.WriteLine("What is your name");
        //    string name = Console.ReadLine();

        //    Console.WriteLine("Type a number between 1 and 10");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    if (name=="bob" && (number == 2 || number == 7)) // Condition (|| = OR )
        //    {
        //        Console.WriteLine("You have won"); // Action
        //    }
        //    else
        //    {
        //        Console.WriteLine("Try again");
        //    }


        //    // Keeo the CLI open!
        //    Console.ReadLine();
        //}


        // Excercise 3 - Building a calculator

        //static void Main(string[] args)
        //{
        //    // Welcome message
        //    Console.WriteLine("Welcome to our cool calculator!");

        //    Console.WriteLine("What is your first number?");
        //    double firstNumber = Convert.ToDouble(Console.ReadLine());

        //    Console.WriteLine("Choose an operator: + - / * ");
        //    string op = Console.ReadLine();

        //    Console.WriteLine("What is your second number?");
        //    double secondNumber = Convert.ToDouble(Console.ReadLine());

        //    double result = 0;

        //    if (op == "+")
        //    {
        //        result = firstNumber + secondNumber;
        //    }
        //    else if (op == "*")
        //    {
        //        result = firstNumber * secondNumber;
        //    }
        //    else if (op == "-")
        //    {
        //        result = firstNumber - secondNumber;
        //    }
        //    else if (op == "/")
        //    {
        //        result = firstNumber / secondNumber;
        //    }

        //    Console.WriteLine("The result is: " + result);

        //    // Keeo the CLI open!
        //    Console.ReadLine();
        //}


        // Switch statements
        //static void Main(string[] args)
        //{
        //    // Welcome message
        //    Console.WriteLine("Please enter a day od the week");
        //    string input = Console.ReadLine();

        //    switch (input)
        //    {
        //        case "monday":
        //            Console.WriteLine("I dislike Mondays");
        //            break;
        //        case "tueday":
        //            Console.WriteLine("Tuesday Tuesday Tuesday");
        //            break;
        //        case "wednesday":
        //            Console.WriteLine("Wednesday are neh!");
        //            break;
        //        case "thursday":
        //            Console.WriteLine("Thurdfays are nice because I only work half day.");
        //            break;
        //        case "friday":
        //            Console.WriteLine("It's the weekend tomorrow");
        //            break;
        //        case "saturday":
        //            Console.WriteLine("Saturday is great because I don't have to work");
        //            break;
        //        case "sunday":
        //            Console.WriteLine("I'm not looking forward to work again on Monday!");
        //            break;
        //        default: // This works like the 'else' statement
        //            Console.WriteLine("You entered an invalid day!");
        //            break;

        //        // switch statements cant execute complex conditions, it improves readability. If your elseif statememts exceeds 5, change to switch statetements because it execute faster

        //    }

        //    //if (input == "monday")
        //    //{
        //    //    Console.WriteLine("I dislike Monday");
        //    //}
        //    //else if (input == "tuesday")
        //    //{
        //    //    Console.WriteLine("Tuesday Tuesday Tuesday");
        //    //}
        //    //else if (input == "wednesday")
        //    //{
        //    //    Console.WriteLine("Wednesday are neh!");
        //    //}
        //    //else if (input == "thurday")
        //    //{
        //    //    Console.WriteLine("Thurdays are nice because I only work half a day");
        //    //}

        //    //Console.WriteLine("The result is: " + result);

        //    // Keeo the CLI open!
        //    Console.ReadLine();
        //}


        //// Conditional/tenary Operators
        //static void Main(string[] args)
        //{
        //    // Ask the user id they like coffee
        //    Console.WriteLine("Do you like Coffee?");
        //    string answer = Console.ReadLine();

        //    //string message;
        
        //    //if (answer == "yes")
        //    //    message = "I knew I could count on you!";
        //    //else
        //    //    message = "We 're not friends anymore";

        //    // The statement below is same as the code block above
        //    string message = (answer == "yes") ? "I knew I could count on you!" : "We 're not friends anymore";

        //    // Output the message to the user
        //    Console.WriteLine(message);


        //    // Keep the CLI open!
        //    Console.ReadLine();
        //}


        // 5.0 Arrays - This is a collection of some things
        //static void Main(string[] args)
        //{
        //    //int num1 = 5;
        //    //int num2 = 3;
        //    //int num3 = 8;
        //    //int num4 = 13;
        //    //int num5 = 9;
        //    //int num6 = 4;

        //    // Rewriting above in an array
        //    //int[] numbers = new int[] { 5, 3, 8, 13, 9, 4 };
        //    //string[] names = new string[] { "titilope", "ayodeji", "banjoko" };

        //    int[] numbers = new int[5];
        //    numbers[0] = 2;

        //    string[] names = new string[5];
        //    names[0] = "Titilpe";

        //    // How to access the values
        //    Console.WriteLine(numbers[0]);
        //    Console.WriteLine(names[0]);

        //    // Keep the CLI open!
        //    Console.ReadLine();
        //}


        // While loop
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Welcome to the number counter!");

        //    Console.WriteLine("Enter a number between 1 and 100:");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    int counter = 1;

        //    while (counter <= number)
        //    {
        //        Console.WriteLine(counter);
        //        counter++;
        //    }

        //    // Keep the CLI open!
        //    Console.ReadLine();
        //}

        // Do while loop
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Welcome to the number counter!");

        //    Console.WriteLine("Enter a number between 1 and 100:");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    int counter = 1;

        //    do
        //    {
        //        Console.WriteLine(counter);
        //        counter++;
        //    }
        //    while (counter <= number);


        //     // Keep the CLI open!
        //     Console.ReadLine();
        //}


        // For loop
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Welcome to the number counter!");

        //    Console.WriteLine("Enter a number between 1 and 100:");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    //int counter = 1;

        //    //do
        //    //{
        //    //    Console.WriteLine(counter);
        //    //    counter++;
        //    //}
        //    //while (counter <= number);
            
        //    for (int counter1 = 1; counter1 <= number; counter1++ ) // or counter = counter + 2 instead of counter++)
        //    {
        //        Console.WriteLine(counter1);
        //    }
        //    // For loop is used when we know the number of times the block will iterate
        //    // While loop is used when we dont know the number of iterations.

        //    // Keep the CLI open!
        //    Console.ReadLine();
        //}

        // For each loop
        // For loop
        //static void Main(string[] args)
        //{
        //    // Define am array
        //    int[] numbers = new int[] { 1, 4, 9, 12, 34, 44, 56, 78, 89, 92, 99 };

        //    // output each number to the screen using a FOR loop!
        //    for(int num = 0; num < numbers.Length; num++)
        //    {
        //        Console.WriteLine(numbers[num]);
        //    }

        //    foreach (int num in numbers)
        //    {
        //        Console.WriteLine(num);
        //    }

        //    // Keep the CLI open!
        //    Console.ReadLine();
        //}

        // Exercise 3 - Draw a cube
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter a number and I will draw a cube for the size of your number");
        //    int num = Convert.ToInt32(Console.ReadLine());

        //    for (int y = 0; y < num; y++)
        //    {
        //        for(int x = 0; x < num; x++)
        //        {
        //            Console.Write("*");
        //        }
        //        Console.WriteLine("*");
        //    }

        //    // Keep the CLI open!
        //    Console.ReadLine();
        //}


        // Break statement
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter a number and I will count up to your number");
        //    int num = Convert.ToInt32(Console.ReadLine());

        //    int counter = 1;

        //    while (true)
        //    {
        //        if (counter > num) break;

        //        Console.WriteLine(counter);
        //        counter++;
        //    }

        //    // Keep the CLI open!
        //    Console.ReadLine();
        //}


        // Continue statement
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter a number and I will skip your number when counting to 10!");
        //    int num = Convert.ToInt32(Console.ReadLine());

        //    for(int c = 0; c <= 10; c++)
        //    {
        //        if (c == num) continue;

        //        Console.WriteLine(c);
        //    }

        //    // Keep the CLI open!
        //    Console.ReadLine();
        //}


        // Exception handling (try/catch)
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("*** Welcome to the number divider!");

        //    try
        //    {
        //        Console.WriteLine("Enter your first number: ");
        //        int num1 = Convert.ToInt32(Console.ReadLine());

        //        Console.WriteLine("Enter your second number: ");
        //        int num2 = Convert.ToInt32(Console.ReadLine());

        //        int result = num1 / num2;

        //        Console.WriteLine("The result is: " + result);
        //    }
        //    catch (FormatException e)
        //    {
        //        Console.WriteLine("Please learn to read properly");
        //    }
        //    catch (DivideByZeroException e)
        //    {
        //        Console.WriteLine("Hey buddy! You cannot divide by zero!");
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("An error has occured! " + e.Message);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Thank you for using our prgram!");
        //    }


        //    // Keep the CLI open!
        //    Console.ReadLine();
        //}

        // 2D, 3D Dimensional Array
        //static void Main(string[] args)
        //{
        //    // 2D
        //    // 1, 2, 3
        //    // 4, 5, 6
        //    // 7, 8, 9

        //    // Define some cool numbers
        //    //int[,] num = new int[,] { {1, 2, 3},{4, 5, 6}, {7, 8, 9} };

        //    // 3D
        //    // 1, 2
        //    // 4, 5

        //    int[,,] num = new int[,,] { { { 1, 2 }, { 1, 2 } }, { { 1, 2}, { 1, 2} } };

        //    Console.WriteLine("The first number in the array is: " + num[0, 0, 0]);

        
        //    // Keep the CLI open!
        //    Console.ReadLine();
        //}


        // Lists
        static void Main(string[] args)
        {
            // Define some cool numbers
            int[] numbers = new int[] { 4649, 3, 67, 248, 1, 67, 546, 33, 236, 98, 12, 6543 };

            List<int> list = new List<int>(numbers);

            list.Sort();

            // Output each number to the screen;
            foreach (int num in list)
            {
                Console.WriteLine(num);
            }

            // Keep the CLI open!
            Console.ReadLine();
        }
    }
}