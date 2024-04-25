using System;

class Program
{
    static void Main(string[] args)
    {
        // Define Functions
        // Welcome
        DisplayWelcomeMessage();

        // ID name
        string inputName = PromptUserName();

        // ID favorite number
        int userNumber = PromptUserNumber();

        // Square number
        int squaredNumber = SquareNumber(userNumber);


        // Display results
        DisplayResult(inputName, squaredNumber);

    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()

    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;

    }
    static void DisplayResult(string inputName, int squaredNumber)
    {
        Console.WriteLine($"{inputName}, your favorite number squared is {squaredNumber}.");
        Console.WriteLine("");

    }
    
}