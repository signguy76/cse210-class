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
        Console.Write("Guess the magic number between 1 and 100? ");
        int guessNumber = -1;
        while (guessNumber != magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());


            if (guessNumber == magicNumber)
            {
                Console.WriteLine($"You are right. The magic number is {magicNumber}.");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Guess higher.");
            }
            else
            {
                Console.WriteLine("Guess lower.");
            }
        }

    }
}