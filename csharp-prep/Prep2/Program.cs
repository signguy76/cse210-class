using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your percentage grade. ");
            int percentage = int.Parse(Console.ReadLine());
            {
                if (percentage >=90)
                {
                    Console.WriteLine("Your grade is an A.");
                }
                else if (percentage >=80)
                {
                Console.WriteLine("Your grade is a B.");
                }
                else if (percentage >=70)
                {
                Console.WriteLine("Your grade is a C.");
                }
                else if (percentage >=60)
                {
                Console.WriteLine("Your grade is a D.");
                }
                else 
                {
                    Console.WriteLine("Sorry, your grade is an F.");
                }
            }
    }
}