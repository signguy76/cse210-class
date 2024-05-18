using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;




class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter duration in seconds:");
                    int breathingDuration = int.Parse(Console.ReadLine());
                    new BreathingActivity(breathingDuration).Start();
                    break;
                case "2":
                    Console.WriteLine("Enter duration in seconds:");
                    int reflectionDuration = int.Parse(Console.ReadLine());
                    new ReflectionActivity(reflectionDuration).Start();
                    break;
                case "3":
                    Console.WriteLine("Enter duration in seconds:");
                    int listingDuration = int.Parse(Console.ReadLine());
                    new ListingActivity(listingDuration).Start();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                    break;
            }
        }
    }
}
