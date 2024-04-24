using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);        
        //Console.Write("What is your magic number? ");
        //    int magicNumber = int.Parse(Console.ReadLine());
        Console.Write("What is your guess? ");
            int guessNumber = int.Parse(Console.ReadLine());
        if (guessNumber == magicNumber)
        {
            Console.WriteLine($"You are right, the number is {guessNumber}");

        }
        else if (guessNumber < magicNumber )
        {
            Console.WriteLine("Guess higher.");
        }
        else
        {
            Console.WriteLine("Guess lower.");
        }

    }
}