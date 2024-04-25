using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbs = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number for the list, enter 0 to quit. ");

            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbs.Add(userNumber);
            }
            Console.WriteLine("The numbers in the list are:");
            foreach (int numb in numbs)
            {
                
                Console.WriteLine(numb);
            }
            // Total numbers
            int total = 0;
            foreach (int numb in numbs)
            {
                total += numb;

            }
            Console.WriteLine($"The total of the numbers in the list is {total}.");
            int allNumbs = (numbs.Count);
            // Average
            float average = (float)total / allNumbs;
            Console.WriteLine("The average of the numbers is " + average);

            // Highest number
            int highNumb = numbs[0];

            foreach (int numb in numbs)
            {
                if (numb > highNumb)
                {
                    highNumb = numb;
                }
                

            }
            Console.WriteLine($"The highest number is: {highNumb}");
        }

        




    }
}