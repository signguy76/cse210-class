using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)

    {
        string letter = "";
        Console.WriteLine("");
        Console.Write("What is your grade percentage? ");
        string yourGrade = Console.ReadLine();
        int yourGradeNumber = int.Parse(yourGrade);
        // Test parse 
        Console.Write($"At {yourGradeNumber}%, ");
        if (yourGradeNumber >= 90)
        {
            letter = "A";
            Console.WriteLine($"Congradulations, you passed the course.");
        }
        else if (yourGradeNumber >= 80)
        {
            letter = "B";

            Console.WriteLine($"Congradulations, you passed the course.");
        }
        else if (yourGradeNumber >= 70)
        {
            letter = "C";
            Console.WriteLine($"Congradulations, you passed the course.");
        }
        else if (yourGradeNumber >= 60)
        {
            letter = "D";
            Console.WriteLine($"you have not passed. You must have at least 70% to pass the class. Please re-enroll.");
        }
        else if (yourGradeNumber < 60)
        {
            letter = "F";
            Console.WriteLine($"you have not passed. You must have at least 70% to pass the class. Please re-enroll.");
        }
        {

            Console.WriteLine($"Your final letter grade is {letter}.");
            Console.WriteLine("");
        }


    }
}